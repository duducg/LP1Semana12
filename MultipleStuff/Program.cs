using System;
namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList sp = new SuperList(12f,222f,0.3f,1f,34f,19f,35f);            
            sp.GetMinMax1(out double min1,out double max1);
            Console.WriteLine($"{min1} , {max1}");

            SuperList.OutputStruct newout = sp.GetMinMax2();
            Console.WriteLine($"{newout.Min} , {newout.Max}");

            Tuple<double, double> gmm3 = sp.GetMinMax3();
            Console.WriteLine($"{gmm3.Item1} , {gmm3.Item2}");

            (double minimum,double maximum) gmm4 = sp.GetMinMax4();
            Console.WriteLine($"{gmm4.minimum} , {gmm4.maximum}");


        }
    }
}
