using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust;
            //Programm kuvab kasutaja vanust konsoolis;

            Console.WriteLine("Palun sisesta oma sünniaasta:");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());

            int userAge = 2023 - yearofBirth;

            //Console.WriteLine("Oled " + userAge + "aastat vana.");

            //string interpolation

            Console.WriteLine($"Oled {userAge} aastat vana.");



        }
    }
}
