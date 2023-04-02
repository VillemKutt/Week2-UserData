using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //Programm arvutab kasutaja sünniaastat;
            //Programm kuvab sünniaastat konsoolis;
            //"Oled sündinud aastal {yearofBirth}";

            Console.WriteLine("Palun sisesta oma vanus:");
            int userAge = Convert.ToInt32(Console.ReadLine());


            int yearofBirth = 2023 - userAge;

            Console.WriteLine($"Oled sündinud aastal {yearofBirth} .");


        }
    }
}
