using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FarenheitToCelcius(double f)
        {
          return  (f - 32) * 5/9;
        }
        public static double CelciusToFarenheit(double c)
        {
            return (c * 1.8) + 32;
        }
    }
}
