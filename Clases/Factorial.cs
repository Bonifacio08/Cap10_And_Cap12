using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10_And_Cap12.Capitulo_10
{
    public class Factorial
    {
        public int Numero = 5;
        public int factorial = 1;

        public void Fact(int _Numero, int _Factorial)
        {
            if (Numero >= 0)
            {
                for (int i = Numero; i >= 2; i--)
                {
                    factorial *= i;
                }
                Console.WriteLine($"Factorial de {Numero} = {factorial}");
            }
            else
            {
                Console.WriteLine("Numero negavito");
            }
        }
    }
}
