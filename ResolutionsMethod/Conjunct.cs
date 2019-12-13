using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolutionsMethod
{
    public class Conjunct : ComplexExpression
    {
        List<Disjunct> _disjuncts;

        public Conjunct() : base()
        {
            _disjuncts = new List<Disjunct>();
        }

        public Conjunct(Conjunct c) : base()
        {
            _disjuncts = new List<Disjunct>();
            foreach (var d in c._disjuncts)
            {
                _disjuncts.Add(new Disjunct(d));
            }
        }

        public Conjunct(Disjunct d)
        {
            _disjuncts = new List<Disjunct>();
            _disjuncts.Add(new Disjunct(d));
        }

        public bool IsNonContradictory(ref Estimation contrary, HashSet<Literal> used)
        {
            int firstContraryDisjunctIdx = 0, secondContraryDisjunctIdx = 0;
            var conjunctCopy = new Conjunct(this);

            return ProcessResolutionsMethod(ref contrary);
            
            bool ProcessResolutionsMethod(ref Estimation contraryInstance)
            {
                while (true)
                {
                    conjunctCopy._disjuncts = 
                        conjunctCopy._disjuncts.Distinct(new Disjunct.DisjunctComparer()).ToList();
                
                    if (SearchForContraryPair(ref firstContraryDisjunctIdx, ref secondContraryDisjunctIdx))
                    {
                        Debug.WriteLine("\nNow conjunct looks like "); conjunctCopy.Print();
                    
                        var d1 = conjunctCopy._disjuncts[firstContraryDisjunctIdx];
                        var d2 = conjunctCopy._disjuncts[secondContraryDisjunctIdx];
                    
                        Debug.WriteLine("\nHas contrary pair: "); d1.Print();
                        Debug.WriteLine(" and "); d2.Print();
                    
                        var resolventa = Disjunct.GetResolventa(d1, d2);
                    
                        Debug.WriteLine("\nTheir resolventa: "); resolventa.Print();

                        if (d1.IsElementary() && d2.IsElementary())
                        {
                            conjunctCopy._disjuncts.Remove(d1);
                            conjunctCopy._disjuncts.Remove(d2);
                        }
                        else
                        {
                            if (!d1.IsElementary()) conjunctCopy._disjuncts.Remove(d1);// At(firstContraryDisjunctIdx);
                            if (!d2.IsElementary()) conjunctCopy._disjuncts.Remove(d2); // At(secondContraryDisjunctIdx);
                        }

                        if (!resolventa.IsEmpty()) conjunctCopy._disjuncts.Add(resolventa);
                    }
                    else 
                    {
                        if (conjunctCopy._disjuncts.Count == 0) return true;
                        break;
                    }
                }

                var startSingle =
                    conjunctCopy._disjuncts.FindAll(d => d.IsElementary());
                contraryInstance = new Estimation();
                foreach (var d in startSingle)
                {
                    var l = d.Literal(0);
                    contraryInstance.EstimateVariable(l, Estimation.True);
                }

                conjunctCopy = new Conjunct(this);

                while (true)
                {
                    conjunctCopy._disjuncts =
                        conjunctCopy._disjuncts.Distinct(new Disjunct.DisjunctComparer()).ToList();

                    foreach (var d in conjunctCopy._disjuncts)
                    {
                        if (d.IsElementary())
                        {
                            if (contraryInstance.GetEstimation(d.Literal(0)) == Estimation.False) 
                                return true;
                            else contraryInstance.EstimateVariable(d.Literal(0), Estimation.True);
                        }
                        else if (d.Size == 2)
                        {
                            var l1 = d.Literal(0);
                            var l2 = d.Literal(1);

                            int est1 = contraryInstance.GetEstimation(l1);
                            int est2 = contraryInstance.GetEstimation(l2);
                            if (est1 == Estimation.True || est2 == Estimation.True)
                                continue;

                            if (est1 == Estimation.False && est2 == Estimation.False)
                                return true;

                            if (est1 == Estimation.Undefined)
                                contraryInstance.EstimateVariable(l1, Estimation.True);
                            else if (est2 == Estimation.Undefined)
                                contraryInstance.EstimateVariable(l2, Estimation.True);
                        }
                    }

                    if (SearchForContraryPair(ref firstContraryDisjunctIdx, ref secondContraryDisjunctIdx))
                    {
                        Debug.WriteLine("\nNow conjunct looks like "); conjunctCopy.Print();

                        var d1 = conjunctCopy._disjuncts[firstContraryDisjunctIdx];
                        var d2 = conjunctCopy._disjuncts[secondContraryDisjunctIdx];

                        Debug.WriteLine("\nHas contrary pair: "); d1.Print();
                        Debug.WriteLine(" and "); d2.Print();

                        var resolventa = Disjunct.GetResolventa(d1, d2);

                        Debug.WriteLine("\nTheir resolventa: "); resolventa.Print();

                        if (d1.IsElementary() && d2.IsElementary())
                        {
                            conjunctCopy._disjuncts.Remove(d1);
                            conjunctCopy._disjuncts.Remove(d2);
                        }
                        else
                        {
                            if (!d1.IsElementary()) conjunctCopy._disjuncts.Remove(d1);// At(firstContraryDisjunctIdx);
                            if (!d2.IsElementary()) conjunctCopy._disjuncts.Remove(d2); // At(secondContraryDisjunctIdx);
                        }

                        if (!resolventa.IsEmpty()) conjunctCopy._disjuncts.Add(resolventa);
                    }
                    else
                    {
                        if (conjunctCopy._disjuncts.Count == 0) return true;
                        break;
                    }
                }

                foreach (var usedVar in used)
                {
                    if (contraryInstance.GetEstimation(usedVar) == Estimation.Undefined)
                        contraryInstance.EstimateVariable(usedVar, Estimation.True);
                }
                return false;
            }

            bool SearchForContraryPair(ref int i1, ref int i2)
            {
                for (int i = 0; i < conjunctCopy._disjuncts.Count; i++)
                {
                    for (int j = i + 1; j < conjunctCopy._disjuncts.Count; j++)
                    {
                        var d1 = conjunctCopy._disjuncts[i];
                        var d2 = conjunctCopy._disjuncts[j];
                        if (i != j && d1.HasContraryPair(d2))
                        {
                            i1 = i;
                            i2 = j;
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        public Conjunct Negation()
        {
            var ans = new Conjunct();
            foreach (var d in _disjuncts)
            {
                var c = d.Negation();
                ans = ans.Disjunction(c);
            }
            return ans;
        }

        public bool IsEmpty()
        {
            if (_disjuncts.Count == 0) return true;
            return false;
        }

        public Conjunct Disjunction(Conjunct c)
        {
            var ans = new Conjunct();

            if (IsEmpty())
            {
                return new Conjunct(c);
            } 
            if (c.IsEmpty())
            {
                return new Conjunct(this);
            }

            foreach (var d1 in _disjuncts)
            {
                foreach (var d2 in c._disjuncts)
                {
                    var d = d1.Add(d2);
                    ans.Join(d);
                }
            }
            return ans;
        }

        public Conjunct Add(Disjunct d)
        {
            var ans = new Conjunct(this);
            ans.Join(d);
            return ans;
        }

        public Conjunct Add(Conjunct c)
        {
            var ans = new Conjunct(this);
            ans.Join(c);
            return ans;
        }

        public void Join(Disjunct d)
        {
            _disjuncts.Add(new Disjunct(d));
        }

        public void Join(Conjunct c)
        {
            foreach (var d in c._disjuncts)
            {
                Join(d);
            }
        }

        public void Print()
        {
            for (int i = 0; i < _disjuncts.Count; i++)
            {
                _disjuncts[i].Print();
                if (i != _disjuncts.Count - 1) Debug.Write(", ");
            }
        }
    }
}
