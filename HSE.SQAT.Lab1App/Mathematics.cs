using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSE.SQAT.Lab1App
{
    public class Mathematics
    {
        public static List<double> GetSquareRoots(double a, double b, double c)
        {
            if (a == 0) throw new ArgumentException();
            double discriminant = b * b - 4 * a * c;
            if (discriminant == 0)
            {
                double result = -b / (2 * a);
                return new List<double>() { result };
            }
            else
            {
                if (discriminant < 0)
                {
                    return null;
                }
                else
                {
                    var result = new List<double>();
                    var res1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    var res2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    result.Add(res1);
                    result.Add(res2);
                    return result;
                }
            }
        }
    }
}
