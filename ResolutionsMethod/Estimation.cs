using System;
using System.Collections.Generic;
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

        Dictionary<string, int> _estimations;

        public Estimation()
        {
            _estimations = new Dictionary<string, int>();
        }

        public void AddVariable(string name)
        {
            AddVariable(name, Undefined);
        }

        public void AddVariable(string name, int est)
        {
            _estimations.Add(name, est);
        }

        public void EstimateVariable(string name, int est)
        {
            _estimations[name] = est;
        }
    }
}
