using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalTests01
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "123.00";

            int integer = int.Parse(value, 
                NumberStyles.AllowDecimalPoint, 
                CultureInfo.CreateSpecificCulture("en-US"));

            Console.WriteLine(integer);
        }
    }
}
