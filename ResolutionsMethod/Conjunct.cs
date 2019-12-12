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

        public bool IsNonContradictory()
        {
            int idx1 = 0, idx2 = 0;
            var c = new Conjunct(this);
            Debug.WriteLine("\nNew: "); c.Print();
            while (true)
            {
                c._disjuncts = c._disjuncts.Distinct(new Disjunct.DisjunctComparer()).ToList();
                if (SearchForContraryPair(ref idx1, ref idx2))
                {
                    Debug.WriteLine("\nNow conjunct looks like "); c.Print();
                    var d1 = c._disjuncts[idx1];
                    var d2 = c._disjuncts[idx2];
                    Debug.WriteLine("\nHas contrary pair: "); d1.Print();
                    Debug.WriteLine(" and "); d2.Print();
                    var resolventa = Disjunct.GetResolventa(d1, d2);
                    Debug.WriteLine("\nTheir resolventa: "); resolventa.Print();
                    c._disjuncts.RemoveAt(idx2);
                    c._disjuncts.RemoveAt(idx1);
                    if (!resolventa.IsEmpty()) c._disjuncts.Add(resolventa);
                }
                else 
                {
                    if (c._disjuncts.Count == 0) return true;
                    if (IsContraryInstance()) return false;
                    if (!AddDisjunctFromSource()) return false;
                }
            }

            bool IsContraryInstance()
            {
                var conclusion = _disjuncts[0];
                bool isContrIns = true;
                foreach (var d in c._disjuncts)
                {
                    var n = conclusion.Negation();
                    if (d.Contains(conclusion) || d.IsElementary()) continue;
                    isContrIns = false;
                    break;
                }
                return isContrIns;
            }

            bool AddDisjunctFromSource()
            {
                var d0 = c._disjuncts[0];
                foreach (var d in _disjuncts)
                {
                    if (d.HasContraryPair(d0))
                    {
                        c._disjuncts.Add(new Disjunct(d));
                        return true;
                    }
                }
                return false;
            }

            bool SearchForContraryPair(ref int i1, ref int i2)
            {
                for (int i = 0; i < c._disjuncts.Count; i++)
                {
                    for (int j = i + 1; j < c._disjuncts.Count; j++)
                    {
                        var d1 = c._disjuncts[i];
                        var d2 = c._disjuncts[j];
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
