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
                Join(new Disjunct(d));
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
