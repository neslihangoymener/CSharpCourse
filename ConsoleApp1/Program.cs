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
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            //students[0] = "Engin";
            //students[1] = "Derin";
            //students[2] = "Salih";

           // string[] students2 = new []{"Engin","Derin","Salih"};
           // string[] students2 = new[] { "Engin", "Derin", "Salih" };

            //foreach (var student in students2) 
            //{
            //    Console.WriteLine(student);

            //}

            string[,] regions=new string[5,3]
            //regions[0,0]="İstanbul"
            {
                {"İstanbul","İzmit","Balıkesir"},
                {"Ankara","Konya","Kırıkkale"},
                {"Antalya","Adana","Mersin"},
                {"Riza","Trabzon","Sinop"},
                {"İzmir","Muğla","Manisa"},
        
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("******************");
            }

            //Console.WriteLine();
            Console.ReadLine();
        }
    }
}
