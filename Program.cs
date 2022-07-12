using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        //public delegate bool CheckNums(int num);

        //public delegate void ChangeString(string str);

        public delegate string StringLenght(string str,int m);
        static void Main(string[] args)
        {
            #region Predicate,Action

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(Sum(CheckOdd, arr));
            //Console.WriteLine(Sum(CheckEven, arr));
            //Console.WriteLine(Sum(CheckMoreThanFive, arr));

            //List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = numbers.FindAll(m => m > 6 && m < 9);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //Test(StringToLower, "Ilkin");
            //Test(StringToUpper, "Ilkin");

            //ChangeString change = StringToUpper;
            //change += StringToLower;
            //change += delegate (string s)
            //{
            //    Console.WriteLine(s.ToLower());
            //};
            //change += s => Console.WriteLine(s.ToLower());

            //change("Ilkin");

            //Action<string,int,string> action = StringToUpper;
            //action += StringToLower;

            //action("Ilkin",101,"-p130");
            #endregion


            //Console.WriteLine(Test(StrLength, "Mirsamir" ,22));
            Func<string, int, string> func = StrLength;
            Func<string,int,int> func2= StrLenghts2;
            Console.WriteLine(func2("Emil",17));
        }



        public static string StrLength(string str,int m) 
        {
            return str.Length.ToString() + "=Age:" + m;
        }
        public static int StrLenghts2(string str,int m) 
        {
            return str.Length + m;
        }

        public static string Test (StringLenght func, string str, int m ) 
        {
            return func(str, m);
        }
      
        public static void StringToUpper(string str,int m,string t)
        {
            Console.WriteLine(str.ToUpper () + "-" + m + t);
        }
        public static void StringToLower(string str,int m,string t)
        {
            Console.WriteLine(str.ToLower() + "-" + m +t);
        }

        //public static void Test(ChangeString func, string str) 
        //{
        //    func(str);
        //}





        public static bool CheckOdd(int number) 
        {
            return number % 2 != 0;
        }
        public static bool CheckEven(int number)
        {
            return number % 2 == 0;
        }
        public static bool CheckMoreThanFive(int number) 
        {
            return number > 5;
        }



        public static int Sum(Predicate<int> predicate,  int[] nums) 
        {
            var sum = 0;
            foreach (var item in nums)
            {
                if (predicate(item))
                {
                    sum += item;
                }
            }

            return sum;
        }

        //public static int SumEven(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}

        //public static int SumMoreThanFive(int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (item > 5)
        //        {
        //            sum += item;
        //        }
        //    }

            //return sum;
        //}
    }
}
