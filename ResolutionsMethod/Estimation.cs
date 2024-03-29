﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolutionsMethod
{
    public class Estimation
    {
        public static int True = 1;
        public static int False = 0;
        public static int Undefined = -1;

        Dictionary<Literal, int> _estimations;

        public static int Not(int val)
        {
            return 1 - val;
        }

        public Estimation()
        {
            _estimations = new Dictionary<Literal, int>();
        }

        public string Print()
        {
            string ans = "";
            foreach (var varEst in _estimations)
            {
                if (varEst.Key.IsNegation()) continue;
                ans += $"τ({varEst.Key.Name}) = {varEst.Value}, ";
            }
            return ans.Substring(0, ans.Length - 2);
        }

        public void EstimateVariable(Literal l, int est)
        {
            foreach (var es in _estimations)
            {
                if (es.Key.IsEqual(l)) return;
            }
            _estimations.Add(new Literal(l), est);
            _estimations.Add(new Literal(l.GetContrary()), Not(est));
        }

        public int GetEstimation(Literal l)
        {
            foreach (var es in _estimations)
            {
                if (es.Key.IsEqual(l)) return es.Value;
            }
            return Undefined;
        }

        // public 
    }
}
