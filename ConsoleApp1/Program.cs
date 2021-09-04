using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("--------------------------");
            Console.WriteLine("Calcular a área do terreno");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Informe a largura do terreno: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o comprimento do terreno: ");
            int comprimento = Convert.ToInt32(Console.ReadLine());

            calcularArea(largura, comprimento);

        }

        static void calcularArea(int largura, int comprimento)
        {
            int area = largura * comprimento;
            Console.WriteLine($@"Área {area} m²");
            //Console.WriteLine("Área = " + area);
            //Console.WriteLine(String.Format(@"Área = {0} ", area));
        }

        

    }
   
}