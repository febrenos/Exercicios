using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double f;
            Console.WriteLine("Informe a temparatura em graus F : ");
            f = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} = {1}",f,ConvertTemp.ConverteFahrenheitToCelsius(f));
            Console.ReadKey();
        }

        static class ConvertTemp
        {

            public static double ConverteFahrenheitToCelsius(double f)
            {
                return (5.0 / 9.0) * (f - 32);
            }
        }
    }
}
