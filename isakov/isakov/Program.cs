using System.Threading.Tasks;
using System.Transactions;

namespace Practice1task
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("Press any button to back menu.");
            Console.ReadLine();
            Console.Clear();
        }
        static void Work1()
        {
            try
            {
                Console.WriteLine("Enter 1 number:");
                double firstNum = Convert.ToInt32(Console.ReadLine());//заводим в переменную Readline и конвертируем в число(double)
                Console.WriteLine("Enter 2 number:");
                double secondNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 3 number:");
                double thirdNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 4 number:");
                double fourthNum = Convert.ToInt32(Console.ReadLine());
                double SredneeZZZZZnachenie = (firstNum + secondNum + thirdNum + fourthNum) / 4;
                Console.WriteLine(SredneeZZZZZnachenie);
            }
            catch
            {
                Console.WriteLine("Error");
            }
            Menu();
        }
        static void Work2()
        {
            try

            {
                Console.WriteLine("Enter 1 number:");
                double one = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2 number:");
                double two = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What do you want from a calculator?");
                Console.WriteLine("1) Addition");
                Console.WriteLine("2) Subtraction");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Division");
                Console.WriteLine("5) Remain");
                string choiseAction = Console.ReadLine();
                if (choiseAction == "1")
                {
                    double sloZZZ = one + two;
                    Console.WriteLine(sloZZZ);
                }
                else if (choiseAction == "2")
                {
                    double vuchit = one - two;
                    Console.WriteLine(vuchit);
                }
                else if (choiseAction == "3")
                {
                    double umnoZZZ = one * two;
                    Console.WriteLine(umnoZZZ);
                }
                else if (choiseAction == "4")
                {
                    double delenie = one / two;
                    Console.WriteLine(delenie);
                }
                else if (choiseAction == "5")
                {
                    double ost = one % two;
                    Console.WriteLine(ost);
                }
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Work3()
        {
            try
            {
                Console.WriteLine("Select the temperature:");
                Console.WriteLine("1) Celsius");
                Console.WriteLine("2) Kelvin");
                Console.WriteLine("3) Fahrenheit");
                string firstDT = Console.ReadLine();
                Console.WriteLine("Enter the temperature");
                double D = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Select the temperature input scale:");
                Console.WriteLine("1) Celsius");
                Console.WriteLine("2) Kelvin");
                Console.WriteLine("3) Fahrenheit");
                string secondDT = Console.ReadLine();
                if (firstDT == secondDT)
                {
                    Console.WriteLine();
                }
                else if (firstDT == "1" && secondDT == "2")
                {
                    Console.WriteLine($" {D} Celsius in Kelvin = {273.15 + D}");

                }
                else if (firstDT == "1" && secondDT == "3")
                {
                    Console.WriteLine($" {D} Celsius in Kelvin = {30 + (2 * D)}");
                }
                else if (firstDT == "2" && secondDT == "1")
                {
                    Console.WriteLine($" {D} Celsius in Kelvin = {-273.15 + D}");

                }
                else if (firstDT == "2" && secondDT == "3")
                {
                    Console.WriteLine($" {D} Celsius in Kelvin = {(D - 273.15) * 9 / 5 + 32}");
                }
                else if (firstDT == "3" && secondDT == "1")
                {
                    Console.WriteLine($" {D} Celsius in Kelvin = {(D - 30) / 2}");

                }
                else if (firstDT == "3" && secondDT == "2")
                {
                    Console.WriteLine($" {D} Celsius in Kelvin = {(D - 32) / 9 / 5 + 273.15}");
                }
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Work4()
        {
            try
            {
                Console.WriteLine("Enter the path to the file");
                string pathToFile = Console.ReadLine();
                string[] mas = pathToFile.Split('/');
                Console.WriteLine(mas[mas.Length - 1]);

            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Work5()
        {
            try
            {
                Console.WriteLine("Enter your sentence");
                string sentence = Console.ReadLine();
                string[] razdel = sentence.Split(' ');
                string max = "";
                for (int i = 0; i < razdel.Length; i++)
                {
                    string len = razdel[i];
                    if (max.Length < len.Length)
                    {
                        max = razdel[i];
                    }
                }
                Console.WriteLine(max);

            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Work6()
        {
            try
            {

                Console.WriteLine("Enter you mas №1");
                string fm = Console.ReadLine();
                string[] fmas = fm.Split(' ');
                Console.WriteLine("Enter you mas №2");
                fm = Console.ReadLine();//перезапись(чтоб лишнее не хранить)
                string[] smas = fm.Split(' ');
                string[] tmas;
                for (int i = 0; i < fmas.Length; i++)
                {
                    Console.Write($"{Convert.ToInt32(fmas[i]) * Convert.ToInt32(smas[i])} ");
                }
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Work7()
        {
            try
            {
                Console.WriteLine("Enter 5 numbers");
                string Num = Console.ReadLine();
                string[] numbers = Num.Split(' ');
                int max = -999999999;
                int min = 999999999;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (max < Convert.ToInt32(numbers[i]))
                    {
                        max = Convert.ToInt32(numbers[i]);
                    }
                }
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (min > Convert.ToInt32(numbers[i]))
                    {
                        min = Convert.ToInt32(numbers[i]);
                    }
                }
                Console.WriteLine($"Max: {max}");
                Console.WriteLine($"Min: {min}");
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Work8()
        {
            try
            {
                Console.WriteLine("Enter the number of steps");
                int step = Convert.ToInt32(Console.ReadLine());
                string p = "";//string потому что дописываем значения
                for (int i = 0; i < step; i++)
                {
                    p += i + 1;
                    Console.WriteLine(p);
                }
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }
        static void Tabl()
        {
            try
            {

                for (int i = 1; i <= 9; i++)
                {                               // (i и j) = 1 потому что табл.умнож. без 0
                    for (int j = 1; j <= 9; j++)
                    {
                        Console.Write($"{i} * {j} = {i * j} | ");

                    }
                    Console.WriteLine();//чтобы не писалось в одну строчку
                }
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }

        static void PerevodSSvar30()
        {
            try
            {
                Console.WriteLine("Enter your number for SS:");
                int NumForSS = Convert.ToInt32(Console.ReadLine());
                string Rezultat = "";
                while (NumForSS > 0)
                {
                    Rezultat = NumForSS % 2 + Rezultat;
                    NumForSS /= 2;

                }
                Console.WriteLine(Rezultat);
            }
            catch
            {
                Console.WriteLine("Error");

            }
            Menu();
        }

        static void Main(string[] args)
        {
            while (true)
            {
                {
                    Console.WriteLine("Choose which task you want to see:");

                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("8");
                    Console.WriteLine("9(tabl)");
                    Console.WriteLine("10(perevodSS)");
                    string choiseTask = Console.ReadLine();

                    Console.Clear();

                    if (choiseTask == "1")
                    {
                        Work1();

                    }
                    else if (choiseTask == "2")
                    {
                        Work2();
                    }
                    else if (choiseTask == "3")
                    {
                        Work3();
                    }
                    else if (choiseTask == "4")
                    {
                        Work4();
                    }
                    else if (choiseTask == "5")
                    {
                        Work5();
                    }
                    else if (choiseTask == "6")
                    {
                        Work6();
                    }
                    else if (choiseTask == "7")
                    {
                        Work7();
                    }
                    else if (choiseTask == "8")
                    {
                        Work8();
                    }
                    else if (choiseTask == "9")
                    {
                        Tabl();
                    }
                    else if (choiseTask == "10")
                    {
                        PerevodSSvar30();
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
            }
        }

    }
}