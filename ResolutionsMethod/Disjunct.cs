using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolutionsMethod
{
    public class Disjunct : ComplexExpression
    {
        List<Literal> _literals;

        public Disjunct() : base()
        {
            _literals = new List<Literal>();
        }

        public Disjunct(Literal l)
        {
            _literals = new List<Literal>();
            _literals.Add(new Literal(l));
        }
        
        public Disjunct(Disjunct d) : base()
        {
            _literals = new List<Literal>();
            foreach (var l in d._literals)
            {
                _literals.Add(new Literal(l));
            }
        }

        bool IsContain(Literal l1)
        {
            foreach (var l2 in _literals)
            {
                if (l1.IsEqual(l2))
                {
                    return true;
                }
            }
            return false;
        }

        public Disjunct Add(Literal l)
        {
            var ans = new Disjunct(this);
            ans.Join(l);
            return ans;
        }

        public Disjunct Add(Disjunct d)
        {
            var ans = new Disjunct(this);
            ans.Join(d);
            return ans;
        }

        public void Join(Literal l)
        {
            if (!IsContain(l))
            {
                var toJoin = new Literal(l);
                _literals.Add(toJoin);
            }
        }

        public void Join(Disjunct d)
        {
            foreach (var l in d._literals)
            {
                Join(l);
            }
        }

        public bool HasContraryPair(Disjunct d)
        {
            foreach (var l1 in _literals)
            {
                foreach (var l2 in d._literals)
                {
                    if (l1.IsContrary(l2)) return true;
                }
            }
            return false;
        }

        public Conjunct Negation()
        {
            var ans = new Conjunct();
            foreach (var l in _literals)
            {
                ans.Join(new Disjunct(l.GetContrary()));
            }
            return ans;
        }
        
        public bool IsEmpty()
        {
            if (_literals.Count == 0) return true;
            return false;
        }

        public Disjunct GetResolventa(Disjunct d)
        {
            var resolventa = new Disjunct();
            
            foreach (var l1 in _literals)
            {
                bool isAdd = true;
                foreach (var l2 in d._literals)
                {
                    if (l1.IsContrary(l2)) isAdd = false;
                }
                if (isAdd)
                {
                    resolventa.Add(l1);
                }
            }

            foreach (var l1 in d._literals)
            {
                bool isAdd = true;
                foreach (var l2 in _literals)
                {
                    if (l1.IsContrary(l2)) isAdd = false;
                }
                if (isAdd)
                {
                    resolventa.Add(l1);
                }
            }

            return resolventa;
        }

        public void Print()
        {
            for(int i = 0; i < _literals.Count; i++)
            {
                _literals[i].Print();
                if (i != _literals.Count - 1) Debug.Write("v");
            }
        }
    }
}
