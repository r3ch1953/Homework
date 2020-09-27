using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class LinearEquation
    {
        public int CoeffA { get; set; }
        public int CoeffB { get; set; }

        public LinearEquation(int coeffA, int coeffB)
        {
            if(coeffA == 0 && CoeffB == 0)
                throw new FormatException("Coefficients A and B are zero");
            else if (coeffA == 0)
                throw new FormatException("Coefficient A is zero");
            else if (coeffB == 0)
                throw new FormatException("Coefficient B is zero");

            CoeffA = coeffA;
            CoeffB = coeffB;
        }

        public int Slove()
        {
            return -CoeffB / CoeffA;
        }

        public override string ToString()
        {
            return $"{CoeffA} * X + ({CoeffB}) = 0";
        }

        public static LinearEquation Parse(string args)
        {
            var coeffs = args.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                LinearEquation linear = new LinearEquation(int.Parse(coeffs[0]), int.Parse(coeffs[1]));
                return linear;
            }
            catch
            {
                throw;
            }           
        }
    }
}
