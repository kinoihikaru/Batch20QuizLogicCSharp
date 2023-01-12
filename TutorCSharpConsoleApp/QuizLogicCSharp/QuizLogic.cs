using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TutorCSharpConsoleApp.QuizLogicCSharp
{
    internal class QuizLogic
    {
        public static void Quiz1()
        {
            Console.Write("Enter Number Integer : ");
            var input = Console.ReadLine();
            int len = input.Length;
            int hasil = 0;

            for (int i = 0; i < len; i++)
            {
                hasil = hasil + (input[i] - '0'); // Char 0 = 48 
            }

            Console.WriteLine("total sum : {0}", hasil);
        }

        public static void Quiz2()
        {
            Console.Write("Enter Number Integer : ");
            string? input = Console.ReadLine();
            int len = input.Length;

            Console.WriteLine("Count : {0}", len);
        }

        public static void Quiz3()
        {
            Console.Write("Enter Number Integer : ");
            var input = Console.ReadLine();
            int len = input.Length - 1 ;

            while (len >= 0)
            {
                Console.Write(input[len]);
                len--;
            }
        }

        public static void Quiz4()
        {
            int len = 0;
            int maxInput = 0;

            do
            {
                Console.Write("Enter integer (Type 0 for exit) : ");
                var input = Console.ReadLine();
                var conver = Convert.ToInt32(input);
                len++;

                
                if (maxInput < conver)
                {
                    maxInput = conver;
                }
                if (conver == 0)
                    break;

            } while (len < maxInput);
            Console.WriteLine("Angka terbesar : {0}", maxInput);
        }

        public static void Quiz5()
        {
            Console.Write("Enter Number : ");
            var input = Console.ReadLine();
            var intInput = Convert.ToInt32(input);

            for (int i = 1; i < intInput; i++)
            {
                if (intInput % i == 0)
                {
                    Console.Write(i);
                }
               
            }
        }

        public static void Quiz6()
        {
            Console.Write("Enter Limit Number : ");
            var input = Console.ReadLine();
            var intInput = Convert.ToInt32(input);

            for (int i = 2; i <= intInput; i++)
            {
                bool prima = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prima = false;
                    }
                }

                if (prima)      
                {
                    Console.Write(i + " ");
                }
            }
        }

        public static void Quiz7()
        {
            Console.Write("Enter strings : ");
            var input = Console.ReadLine();
            string hasil = "";
            var array = input.Split(" ");

            foreach (var item in array)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    if (i == 0)
                    {
                        hasil += item[i];
                    }
                    else if (i == item.Length - 1)
                    {
                        hasil += $"{item[i]} ";
                    }
                    else
                    {
                        hasil += "*";
                    }
                }

            }

            Console.WriteLine(hasil);
        }

        public static void Quiz8()
        {

            DateTime dateValue = DateTime.Today;
            int totalDay = 0;
            for (int i = 0; i < 6; i++)
            {
                DateTime date = dateValue.AddDays(i);
                string day = date.ToString("dddd");
                if (day == "Saturday")
                {
                    Console.WriteLine($"Hari Sabtu : {date}");
                    break;
                }
                totalDay++;

            }
            Console.WriteLine($"{totalDay} hari lagi!");
        }

        public static void Quiz9()
        {
            
        }

        public static void Quiz10()
        {
            int len = 0;
            int[] arr = new int[5];

            do
            {
                Console.Write($"Enter {len+1} number : ");
                var input = Console.ReadLine();
                arr[len] = Convert.ToInt32(input);
                len++;
            } while (len < 5);

            Array.Reverse(arr);
            Console.WriteLine(arr[1]);
        }

        public static bool Quiz11()
        {
            Console.Write("Enter strings : ");
            var input = Console.ReadLine();
            int number1 = 0;
            int number2 = 0;
            bool result;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    number1++;
                }
                else if (input[i] == '}')
                {
                    number2++;
                }
            }

            if (number1 == number2)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            Console.WriteLine(result);
            return result;
        }

        public static void Quiz12()
        {
            int temp = 6;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 10; j >= temp; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                temp++;
            }
            Console.WriteLine("=====================================================");
            temp = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = temp; j <= temp + i - 1; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
                temp++;
            }
            Console.WriteLine("=====================================================");
            temp = 1;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 1; j <= temp; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();

                if (i >= 3)
                {
                    temp--;
                }
                else
                {
                    temp++;
                }
            }
            Console.WriteLine("=====================================================");
            temp = 4;
            int number, temp1 = 0;
            for (int i = 1; i <= 5; i++)
            {
                number = i;
                for (int j = 1; j <= 9; j++)
                {
                    if ((j <= temp) || (j > 9 - temp))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write(number + " ");
                        if (j >= 5)
                        {
                            number--;
                        }
                        else
                        {
                            number++;
                        }
                    }
                }
                temp--;
                Console.WriteLine();
            }
        }



    }
}
