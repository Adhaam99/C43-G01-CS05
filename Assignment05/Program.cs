using System.ComponentModel;

namespace Assignment05
{
    internal class Program
    {

        #region Q1 - Ex

        //public static int ValSum(int X, int Y)
        //{

        //    int Result = X + Y;

        //    return Result;
        //}

        //public static int RefSum(ref int X, ref int Y)
        //{

        //    X = 5;

        //    Y = 10;

        //    int Result = X + Y;

        //    return Result;
        //}

        #endregion

        #region Q2 - Ex

        //public static int ValSumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;

        //    for (int i = 0; i < arr.Length; i++)
        //        sum += arr[i];

        //    return sum;
        //}

        //public static int RefSumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;

        //    for (int i = 0; i < arr.Length; i++)
        //        sum += arr[i];

        //    return sum;
        //}

        #endregion

        #region Q3

        public static void SumSub (int num01 , int num02 , int num03 , int num04 , out int sum, out int sub)

        {
            sum = num01 + num02;
            sub = num03 - num04;
        }
        #endregion

        static void Main(string[] args)
        {
            #region Q1 - Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            /*
             * 1 - Passing by value 'll give the function copy of values to interact with it without affecting the original values in stack
             * 
             * 2 - Passing by Reference 'll give the function reference of object in the stack so modifing object in the function 'll affect the original object values
             */

            //int A = 10;
            //int B = 20;

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine($"Result : {ValSum(A, B)}");

            //Console.WriteLine("After Passing by value");

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            //Console.WriteLine($"Result : {RefSum(ref A, ref B)}");

            //Console.WriteLine("After Passing by Reference");

            //Console.WriteLine($"A : {A}");
            //Console.WriteLine($"B : {B}");

            #endregion

            #region Q2 - Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            /*
             * The two ways 'll give the same output and original object 'll be affected.
             *
             * In value type param assigning new object 'll not affect the original object.
             * 
             * In ref type param assigning new object 'll affect the original object.
             * 
             * The difference 'll be in the way it works in the memory
             */

            //int[] numbers = { 1, 2, 3, 4, 5 };

            //int sum = ValSumArray(numbers);

            //Console.WriteLine($"Result ValSum : {sum}");
            //Console.WriteLine(numbers[0]);

            //Console.WriteLine("==========================================");

            //Console.WriteLine($"Result RefSum : {sum}");
            //Console.WriteLine(numbers[0]);

            #endregion

            #region Q3 - Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            Console.Write("Enter first number of Sum : ");

            int.TryParse(Console.ReadLine(), out int num01);

            Console.Write("Enter Second number of Sum : ");

            int.TryParse(Console.ReadLine(), out int num02);

            Console.Write("Enter first number of Sub : ");

            int.TryParse(Console.ReadLine(), out int num03);

            Console.Write("Enter Second number of Sub : ");

            int.TryParse(Console.ReadLine(), out int num04);

            int Sum , Sub;

            SumSub(num01 , num02 , num03 , num04 , out Sum, out Sub);

            Console.WriteLine($"Sum of {num01} + {num02} = {Sum}");

            Console.WriteLine($"Sub of {num03} - {num04} = {Sub}");





            #endregion
        }
    }
}
