using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! What is your first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Hello, " + firstName + " " + lastName + "!");
            Console.WriteLine("How old are you?");
            string ageInput = Console.ReadLine();

            if (!int.TryParse(ageInput, out int age))
            {
                //töötab siis kui inimene sisestab sõna/tähe, mida ei saa numbriks teisendada
                Console.WriteLine("That is not a number!");
                Console.ReadLine();
            }
            else 
            {
                //vanuse piirang, kontrollib, et inimese vanus jääb 20-60 vahele, kui mitte siis teavitab sellest ka inimest.

                if (age < 20 || age > 60 )
                {
                    Console.WriteLine("Very sorry,this program only gives accurate results between the ages of 20-60.");
                    Console.ReadLine();
                }
                else
                {
                    //Pikkuse ja kaalu küsimine.
                    Console.WriteLine("What is your height(cm)?");
                    string heightInput = Console.ReadLine();
                    Console.WriteLine("What is your weight (kg)?");
                    string weightInput = Console.ReadLine();

                    //pikkuse numbrilise väärtuse kontrollimine
                    if (!double.TryParse(heightInput, out double height) || !(height>0))
                    {
                        //vastus, kui selgub, et sisestatud pikkus pole numbrilise väärtusega
                        Console.WriteLine("That is not a number or height is marked as 0cm!");
                        Console.ReadLine();
                    }
                    //kaalu numbrilise väärtuse kontrollimine
                    else if (!double.TryParse(weightInput, out double weight))
                    {
                        //vastus, kui selgub, et sisestatud kaal pole numbrilise väärtusega
                        Console.WriteLine("That is not a number!");
                        Console.ReadLine();
                    }
                    else
                    {
                        //pikkuse teisendamine  
                        height = height / 100;
                        //Kehamassiindeksi leidmiseks jagatakse kehakaal kilogrammides pikkuse ruuduga meetrites.
                        double bmi = weight / (height * height);
                        bmi = Math.Round(bmi, 2);
                       
                        Console.WriteLine("BMI is " + bmi);
                        if (bmi < 16)
                        {
                            Console.WriteLine("Starving");
                        }
                        else if (bmi <18.6)
                        {
                            Console.WriteLine("Underweight");
                        }
                        else if (bmi < 25.1)
                        {
                            Console.WriteLine("Normal");
                        }
                        else if (bmi < 30.1)
                        {
                            Console.WriteLine("Overweight");
                        }
                        else if (bmi < 35.1)
                        {
                            Console.WriteLine("Obese");
                        }
                        else if (bmi < 40.1)
                        {
                            Console.WriteLine("Clinically Obese");
                        }
                        else
                        {
                            Console.WriteLine("Morbidly Obese");
                        }
                        Console.ReadLine();

                    }

                }



            }

        }
    }
}
