using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Boxing and unboxing

            //Boxing
            int a = 10;
            double b = a;

            Console.WriteLine(b);
            Console.WriteLine(a); // automatic small to big data type

            //Unboxing

            double c = 10.99;
            int d = (int)c;

            Console.WriteLine(c);
            Console.WriteLine(d); // manual big to small data type

            //Arithmatic Oprator

            int aA = 8, bB = 5;
            int sum = Add(aA, bB); 
            int difference = Subtract(aA, bB); 
            int product = Multiply(aA, bB); 
            int quotient = Divide(aA, bB);
            int remainder = Modulo(aA, bB);

            Console.WriteLine("\nArithmatic Operators:");
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);

            // Assignment Operators
            int x = 5;
            x += 3; // x = 8
            x -= 2; // x = 6
            x *= 2; // x = 12
            x /= 4; // x = 3

            Console.WriteLine("\nAssignment Operators:");
            Console.WriteLine("x Final amount: " + x);

            // Comparison Operators
            bool isEqual = aA == bB; 
            bool isNotEqual = aA!= bB;
            bool isGreaterThan = aA > bB; 
            bool isLessThan = aA < bB; 
            bool isGreaterOrEqual = aA >= bB; 
            bool isLessOrEqual = aA <= bB; 

            Console.WriteLine("\nComparison Operators:");
            Console.WriteLine(" == " + isEqual);
            Console.WriteLine(" != " + isNotEqual);
            Console.WriteLine(" > " + isGreaterThan);
            Console.WriteLine(" < " + isLessThan);
            Console.WriteLine(" >= " + isGreaterOrEqual);
            Console.WriteLine(" <= " + isLessOrEqual);

            // Logical Operators
            bool Con1 = true;
            bool Con2 = false;
            bool logicalAnd = Con1 && Con2; // AND operator
            bool logicalOr = Con1 || Con2; // OR operator
            bool logicalNot = !Con1; // NOT operator

            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine("Con1 AND Con2: " + logicalAnd);
            Console.WriteLine("Con1 OR Con2: " + logicalOr);
            Console.WriteLine("NOT Con1: " + logicalNot);


            Console.ReadLine();


        }

        // Methods for arithmetic operations
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;
        static int Multiply(int x, int y) => x * y;
        static int Divide(int x, int y) => x / y;
        static int Modulo(int x, int y) => x % y;

    }
}
