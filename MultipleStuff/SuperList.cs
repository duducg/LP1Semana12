using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public struct OutputStruct 
        {
            public double Min { get; set; }
            public double Max { get; set; }

        }
        private List<double> _list;
        public SuperList(params double[] dlst)
        {
            _list = new List<double>(dlst);
        }
        public void GetMinMax1(out double min, out double max)
        {
            min = _list.Min();
            max = _list.Max();
        }
        public OutputStruct GetMinMax2 ()
        {
            return new OutputStruct() { Min = _list.Min(), Max = _list.Max() };
        }
        public Tuple<double, double> GetMinMax3 ()
        {
            double min = _list.Min();
            double max = _list.Max();
            return Tuple.Create(min, max);
        }
        public (double minimum, double maximum ) GetMinMax4 ()
        {
            double min = _list.Min();
            double max = _list.Max();
            return (min, max);

        }
        


    }
}