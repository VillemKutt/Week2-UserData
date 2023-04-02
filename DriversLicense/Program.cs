using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriversLicense
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja sünniaastat
            //Programm arvustab kasutaja vanust
            //Kui kasutaja on noorem, kui 18, siis programm kuvab konsoolis
            //"Oled liiga noor, et juhilube saada" ;
            //"Oled piisavalt vana, et juhilube saada" ;
            //Kui kasutaja on 18, siis programm kuvab konsoolis
            //"Palju õnne! Nüüd sa saad juhilube taotlea!" ;

            Console.WriteLine("Palun sisestage oma sünniaasta:");
            int yearofBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2023 - yearofBirth;

            if (userAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhilube taotleda.");
            }
            else if(userAge < 18)
            {
                Console.WriteLine("Oled liiga noor, et juhilube saada.");
            }
            else
            {
                Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotlea! ");
            }





        }
    }
}
