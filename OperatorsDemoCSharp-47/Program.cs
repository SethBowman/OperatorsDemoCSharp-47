namespace OperatorsDemoCSharp_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operators
            //Assignment operator = 

            //int x = 5;

            //Arithmetic operators

            int addition = 5 + 5;
            int subtraction = 5 - 5;
            int multiplication = 5 * 5;
            int division = 5 / 5;
            int modulus = 6 % 5; //remainder after divison

            //bool isEven = 5 % 2 == 0;

            //Unary operators
            int x = 3;
            int y = ++x; //pre increment

            Console.WriteLine(x);
            Console.WriteLine(y);

            int a = 3;
            int b = a++; //post increment
            //int c = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            //Console.WriteLine(c);

            int c = 5;
            Console.WriteLine(--c); //pre decrement

            int d = 5;
            Console.WriteLine(d--); //post decrement
            Console.WriteLine(d);

            //Relational operators

            int e = 10;
            int f = 20;

            bool isEqual = e == f;
            bool isNotEqual = e != f;
            bool greaterThan = e > f;
            bool lessThan = e < f;
            bool greaterThanOrEqual = e >= f;
            bool lessThanOrEqual = e <= f;


            //Logical operators

            bool resultOne = e == 10 && f == 20; //&& AND - both things need to be true for it to evaluate to true
            bool resultTwo = e == 10 || f == 10; //|| OR - only one thing needs to be true for it to evaluate to true

            //Null coalescing operator

            int? possiblyNullValue = 1000;
            int notNullNumber = possiblyNullValue ?? 500;
            Console.WriteLine(notNullNumber);
        }
    }
}
