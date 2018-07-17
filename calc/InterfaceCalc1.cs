using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class InterfaceCalc1
    {
        public interface InterfaceCalc
        {
            void Put_A(double a);
            void Clear_A();

            double Multiply(double b);//умножение

            double Sum(double b); //сумма

            double Div(double b); //деление

            double Subtractions(double b); //вычитание

            double sqrt(); //извлечнение квадратного корня

            double Square(); //возведение в квадрат

            double Factorial(); //факториал числа

            double ProisStep(double b); //возведение в произвольную степень

        }
    }
}
