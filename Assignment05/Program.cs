using System.ComponentModel;

namespace Assignment05
{
    internal class Program
    {

        #region Q1 - Ex

        public static int ValSum(int X, int Y)
        {

            int Result = X + Y;

            return Result;
        }

        public static int RefSum(ref int X, ref int Y)
        {

            X = 5;

            Y = 10;

            int Result = X + Y;

            return Result;
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
             * The two ways 'll give the same output
             * 
             * The difference 'll be in the way it works
             */



            #endregion
        }
    }
}
