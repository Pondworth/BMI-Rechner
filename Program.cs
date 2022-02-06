using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Rechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe bitte dein Gewicht (kg) an: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Gebe bitte deine Körpergröße (m) an: ");
            double hight = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (hight * hight);
            string classification = "";

            if (bmi < 18.4)
            {
                classification = "Untergewicht";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                classification = "Normalgewicht";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                classification = "Übergewicht";
            }
            else if (bmi >= 30 && bmi < 34.9)
            {
                classification = "Adipositas Grad 1";
            }
            else if (bmi >= 35 && bmi < 39.9)
            {
                classification = "Adipositas Grad 2";
            }
            else if (bmi >= 40)
            {
                classification = "Adipositas Grad 3";
            }

            Console.WriteLine( );
            Console.WriteLine("Dein BMI beträgt {0}, das ist {1}.", bmi, classification);

            Console.ReadKey();
        }
    }
}
