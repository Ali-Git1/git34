using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] adlar = { "Kamal","Ali","Pasa" };
            Console.Write("Bir herf giriniz :");
            char b = Convert.ToChar(Console.ReadLine()); ;
            int check = 0;

            int location = 0;
            for (int i = 0; i < adlar.Length; i++)
            {
                for (int j = 0; j < adlar[i].Length; j++)
                {
                    if (b == adlar[i][j])
                    {
                        location = j ;
                        Console.WriteLine(adlar[i] + " - " + b + " elementi bu yerdedir : " + location);
                    }
                }

            } 
        }
    }
}
