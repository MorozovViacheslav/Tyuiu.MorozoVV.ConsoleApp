using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.MorozovVV.ConsoleApp.Lab2.V3.Lib
{
    public class DataService
    {
        public double SolveExpressV_3_1(double x, double y) 
        {
            double result = (3 + Math.Exp(y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x)));
            return result;
        }

        public double SolveExpressV_3_2(double x, double y)
        {
            double result = (Math.Pow(y, 2) - Math.Cos(Math.Pow(x, 2)) + 10) / (Math.Pow(x, 2) - Math.Sin(Math.Pow (y, 2)) + 12);
            return result;
        }
    }
}
