using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese su nombre:");
            int nombre;
            nombre = int.Parse(Console.ReadLine());
            Console.WriteLine($"tu nombre es: {nombre}");
        }
    }
}
