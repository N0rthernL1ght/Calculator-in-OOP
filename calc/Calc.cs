using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//класс калькулятора с реализацией
namespace calc
{
    class Calc : InterfaceCalc1
    {
        private double a = 0;

        public void Put_A(double a)
        {
            this.a = a;
        }

        public void Clear_A()
        {
            this.a = 0;
        }

        public double Multiply(double b)
        {
            return a * b;
        }

        public double Sum(double b)
        {
            return a + b;
        }

        public double Div(double b)
        {
            return a / b;
        }

        public double Subtractions(double b)
        {
            return a - b;
        }

        public double Square()
        {
            return Math.Pow(a, 2.0);
        }

        public double sqrt()
        {
            return Math.Sqrt(a);
        }

        public double Factorial()
        {
            double f = 1;

            for (int i = 1; i <= a; i++)
                f = f*(double)i;

            return f;
        }

        public double ProisStep(double b)
        {
            return Math.Pow(a, b);
        }
    }
}
