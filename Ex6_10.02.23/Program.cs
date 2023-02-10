using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_10._02._23
{
    public class Program
    {
        static void Main(string[] args)
        {
            double nmr = 0;
            double soma = 0;

            Console.WriteLine("Digite um número: ");
            nmr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O número digitado foi " + nmr);
            Console.WriteLine("O dobro de " + nmr + " é " + ( nmr * nmr));
            Console.WriteLine("A metade de " + nmr + " é " + ( nmr / nmr));

            
        }
    }
}
