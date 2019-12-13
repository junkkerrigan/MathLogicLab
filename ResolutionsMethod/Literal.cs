using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolutionsMethod
{
    public class Literal : HomogeneousLogicalExpression
    {
        string _symbol = "";
        
        bool _isNegation = false;

        public Literal(Literal l)
        {
            _symbol = l._symbol;
            _isNegation = l._isNegation;
        }

        public Literal(string symbol, bool isNegation) : base()
        {
            _symbol = symbol;
            _isNegation = isNegation;
        }

        public bool IsEqual(Literal l)
        {
            bool ans = 
                (l._symbol == _symbol)
                && (bool.Equals(l._isNegation, _isNegation));
            return ans;
        }

        public bool IsContrary(Literal l)
        {
            return
                l._symbol == _symbol
                && (l._isNegation ^ _isNegation);
        }

        public Literal GetContrary()
        {
            return new Literal(_symbol, !_isNegation);
        }

        public void Print()
        {
            if (_isNegation) Debug.Write("(~");
            else Debug.Write("(");
            Debug.Write($"{_symbol})");
        }
    }
}
