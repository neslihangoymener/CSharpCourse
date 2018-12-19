using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "My name is Neslihan Kuş Göymener";

            var result =sentence.Length;
            var result2 = sentence.Clone();
            sentence = "My name is Murat Göymener";

            boll result3= sentence.EndsWith("ğ");
            boll result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name");
            var.result6 = sentence.IndexOf(" ");

            Console.WriteLine(result6);
            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "İstanbul";
            //string result = city + city2;
            //Console.WriteLine(result);

            Console.WriteLine(string.Format("{0} {1}", city, city2));
        }
    }
}
