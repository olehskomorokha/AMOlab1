using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1AMO
{
    public class Lab1Algoritm
    {
        public Lab1Algoritm() 
        {
        }
        public double LineAlgoritm(double z, double x, double y, double g, double  h)
        {
            double result;
            if((x == 0 && y == 0) || g == 0 || h == 0) 
            {
                MessageBox.Show("Invalid value entered!");
            }
            result = Math.Pow((z + y), (g + h)) / Math.Pow((z + x), ((g + h) / (g * h)));
  
            return result;
        }
        public double branchout(double u, double b, double y, double t, double g, double s)
        {
            double result;
            if( u * b == 0 )
            {
                MessageBox.Show("Invalid value entered!");
            }
            result = Math.Pow((25 * g - s * b - (y * t) / (u * b)), 0.5);

            return result;
        }
        public double Cyclic(double n)
        {
            int m = 15;
            if(n == 0 )
            {
                MessageBox.Show("Invalid value entered!");
            }
            double result = 1;
            for (int i = 1; i <= m; i++)
            {
                result *= 1 / n;
            }
            return result;
        }
    }
}
