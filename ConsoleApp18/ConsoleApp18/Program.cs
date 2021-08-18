using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            string R = "s";
            while (R == "s")
            {
                Console.WriteLine("Escribe el nombre del arhivo");
                string archivo = Console.ReadLine();



                StreamWriter ar;
                ar = File.CreateText(archivo + ".txt");
                ar.WriteLine("Archivo Creado");
                ar.Close();



                Console.WriteLine("Quieres crear otro archivo?");
                Console.WriteLine("s/n");
                R = Console.ReadLine();
                Console.Clear();
                if (R == "no")
                {
                    return;
                }
            }
        }
    }
}