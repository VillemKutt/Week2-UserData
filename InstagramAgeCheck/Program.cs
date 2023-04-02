using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstagramAgeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm kontrollib, kas kasutaja on vanem kui 13 aastat või 13 aastat vana;
            //Kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrami kasutada;
            //Kui kasutaja on noorem, kui 13, siis ta on liiga noor;

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 13)
            {
                Console.WriteLine("Oled piisavalt vana, et Instagram'i kasutada.");
            }
            else if(userAge < 13)
            {
                Console.WriteLine("Oled liiga noor, et Instagram'i kasutada.");
            }
            else
            {
                Console.WriteLine("Oledki 13 aastat vana, nüüd saad endale Instagram'i kontot luua.");
            }

            Console.WriteLine("Kena päeva");




        }
    }
}
