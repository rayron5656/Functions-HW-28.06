using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functionns_HW_28._06
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 8

            Console.WriteLine("Enter a number between 1 - 10");
            int Num8 = int.Parse(Console.ReadLine());
            printnumbername(Num8);


            #endregion

            #region question 9

            Console.WriteLine("Enter a number to count to");
            int num9 = int.Parse(Console.ReadLine());
            CountTill(num9);


            #endregion

            #region question 10

            OneTooTen(0);

            #endregion

            #region question 11

            Console.WriteLine("check for prime");
            int num11 = int.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(num11));


            #endregion

            #region question 12

            int[] PrimeArry = { 2, 4, 9, 13, 17, };
            CheckArrayForPrimeNumbers(PrimeArry);


            #endregion

            #region question 13
            int[] Firstarry = { 4, 2 };
            int[] secArray = { 2, 4 };
            Console.WriteLine(arraysumchecker(Firstarry, secArray));

            #endregion

            #region question 14

            int[,] returnedArray = MatrixReturnF();
            Console.WriteLine("Please Enter a number to check");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CheckIfExist(returnedArray, number));
            #endregion

            #region question 15
            int[] MyArray = { 100, 5, 2, 15, 10, -5 };
            arrayPrintingF(ArraySortingF(MyArray));

            #endregion


        }
        #region question 8 functions

        public static void printnumbername(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                case 10:
                    Console.WriteLine("ten");
                    break;

                default:
                    Console.WriteLine("not a number between 1 to 10.");
                    break;
            }
        }



        #endregion

        #region question 9 functions
        public static void CountTill(int counter)
        {
            for (int i = 0; i <= counter; i++)
            {
                Console.WriteLine(i);
            }
        }
       

        
        #endregion

        #region question 10 functions

        public static void OneTooTen(int num10)
        {
            if (num10 < 10)
            {
                num10++;
                Console.WriteLine(num10);
                OneTooTen(num10);

            }


        }


        #endregion

        #region question 11 functions

        private static int IsPrime(int NumbertoCheck)
        {
            int checker = NumbertoCheck - 1;

            while (checker > 2)
            {
                if (NumbertoCheck % checker == 0)
                {
                    return 0;
                }
                else
                {
                    checker--;
                }
            }
            return 1;
        }

        #endregion

        #region question 12 functions
        public static void CheckArrayForPrimeNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length ; i++)
            {
                int checker = arr[i] - 1;
                bool Prime = true;

                while (checker >= 2)
                {
                    if (arr[i] % checker == 0)
                    {
                       Console.WriteLine($"the number at slot {i+1} is not prime");
                        Prime = false;
                        break;
                    }
                    else 
                    {
                        checker--;
                        Prime = true;
                    }

                }
                if (Prime == true)
                {
                    Console.WriteLine($"the number at slot {i + 1} is prime");
                }
               
            }
        }

        #endregion

        #region question 13 functions
        public static int arraysumchecker(int[]firstrry , int[] secarry)
        {
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i < firstrry.Length; i++)
            {
                sum1 += firstrry[i];
            }
            for (int i = 0; i < secarry.Length; i++)
            {
                sum2 += secarry[i];
            }
            if (sum1 > sum2)
            {
                return 1;
            }
            else if (sum1 < sum2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        #endregion

        #region question 14 functions
        public static int[,] MatrixReturnF()
        {
            int[,] THEArray = new int[10, 10];
            Random RandomNum = new Random();

            for (int i = 0; i < THEArray.GetLength(0); i++)
            {
                for (int k = 0; k < THEArray.GetLength(1) ; k++)
                {
                    RandomNum.Next(0,10); 
                    THEArray[i, k] = RandomNum.Next(0,10); 
                }
            }

            return THEArray;
        }

        public static string CheckIfExist(int[,] ArrayToCheck, int NumberToCheck)
        {
            for (int i = 0; i < ArrayToCheck.GetLength(0); i++)
            {
                for (int k = 0; k < ArrayToCheck.GetLength(1); k++)
                {
                    if (ArrayToCheck[i,k] == NumberToCheck)
                    {
                        return "Exist";
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return "Missed";
        }
        #endregion

        #region question 15 functions
        public static int[] ArraySortingF(int[] arrytosort)
        {
            Array.Sort(arrytosort);
            return arrytosort;
        }

        public static void arrayPrintingF(int[] ArrayToPrint)
        {
            for (int i = 0; i < ArrayToPrint.Length; i++)
            {
                Console.WriteLine(ArrayToPrint[i]);
            }
        }

        #endregion

    }
}
