using System;
using System.Linq;
using System.Text;

namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MyMethod();
            //MyMethod();
            //MyMethod();
            //MyMethod();

            //static void MyMethod1(string fname)
            //{
            //    Console.WriteLine(fname + " Refsnes");
            //}


            //MyMethod1("Liam");
            //MyMethod1("Jenny");
            //MyMethod1("Anja");


            //static void MyMethod(string country = "Norway")
            //{
            //    Console.WriteLine(country);
            //}

            //MyMethod("Sweden");
            //MyMethod("India");
            //MyMethod();
            //MyMethod("USA");


            //static void MyMethod(string fname, int age)
            //{
            //    Console.WriteLine(fname + " is " + age);
            //}

            //MyMethod("Liam", 5);
            //MyMethod("Jenny", 8);
            //MyMethod("Anja", 31);

            //static int MyMethod(int x)
            //{
            //    return 5 + x;
            //}
            //Console.WriteLine(MyMethod(3));


            //static void MyMethod(string child1, string child2, string child3)
            //{
            //    Console.WriteLine("The youngest child is: " + child3);
            //}

            //MyMethod(child3: "John", child1: "Liam", child2: "Liam");

            //static int PlusMethodInt(int x, int y)
            //{
            //    return x + y;
            //}

            //static double PlusMethodDouble(double x, double y)
            //{
            //    return x + y;
            //}

            //int myNum1 = PlusMethodInt(8, 5);
            //double myNum2 = PlusMethodDouble(4.3, 6.26);
            //Console.WriteLine("Int: " + myNum1);
            //Console.WriteLine("Double: " + myNum2);


            //Lesson4 less = new Lesson4();
            //int myNum1 = less.PlusMethod(8, 5);
            //double myNum2 = less.PlusMethod(4.3, 6.26);
            //Console.WriteLine("Int: " + myNum1);
            //Console.WriteLine("Double: " + myNum2);
            //class Lesson4
            //{
            //    public int PlusMethod(int x, int y)
            //    {
            //        return x + y;
            //    }
            //    public double PlusMethod(double x, double y)
            //    {
            //        return x + y;
            //    }
            //}

            //void SayHello() => Console.WriteLine("Hello");

            //void SayHello()
            //{
            //    Console.WriteLine("Hello");
            ////}

            //string GetMessage()
            //{
            //    return "hello";
            //}

            //string GetMessage() => "hello";

            //void Increment(int n)
            //{
            //    n++;
            //    Console.WriteLine($"Число в методе Increment: {n}");
            //}
            //int number = 5;
            //Console.WriteLine($"Число до метода Increment: {number}");
            //Increment(number);
            //Console.WriteLine($"Число после метода Increment: {number}");

            //void Increment(ref int n)
            //{
            //    n++;
            //    Console.WriteLine($"Число в методе Increment: {n}");
            //}
            //int number = 5;
            //Console.WriteLine($"Число до метода Increment: {number}");
            //Increment(ref number);
            //Console.WriteLine($"Число после метода Increment: {number}");

            //void Sum(int x, int y, out int result)
            //{
            //    result = x + y;
            //}
            //int number;
            //Sum(10, 15, out number);
            //Console.WriteLine(number);

            //void Sum(int x, int y, out int result)
            //{
            //    Console.WriteLine(x + y);
            //    result = 0;
            //}

            //void GetRectangleData(int width, int height, out int rectArea, out int rectPerimetr)
            //{
            //    rectArea = width * height;       // площадь прямоугольника - произведение ширины на высоту
            //    rectPerimetr = (width + height) * 2; // периметр прямоугольника - сумма длин всех сторон  
            //}
            //int area;
            //int perimetr;
            //GetRectangleData(10, 20, out area, out perimetr);
            //Console.WriteLine($"Площадь прямоугольника: {area}");
            //Console.WriteLine($"Периметр прямоугольника: {perimetr}");

            ////n! = 1 * 2 * … *n

            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;
            //    return n * Factorial(n - 1);
            //}
            //int factorial4 = Factorial(4);  // 24
            //int factorial5 = Factorial(5);  // 120
            //int factorial6 = Factorial(6);  // 720
            //Console.WriteLine($"Факториал числа 4 = {factorial4}");
            //Console.WriteLine($"Факториал числа 5 = {factorial5}");
            //Console.WriteLine($"Факториал числа 6 = {factorial6}");

            ////if (n == 1) return 1;
            ////return 4 * Factorial(3);

            ////Factorial(3)
            ////return 3 * Factorial(2);

            ////Factorial(2)
            ////return 2 * Factorial(1);

            ////Factorial(1)
            ////if (n == 1) return 1;
            ////1

            //Homework

            Console.WriteLine(MaxValue(10, 4));
            Console.WriteLine(MaxValue(16, 4, 7));
            Console.WriteLine(MaxValue(-16, 4, 7, 55));

            Console.WriteLine(MinValue(15, 2));
            Console.WriteLine(MinValue(15, 4, 1));
            Console.WriteLine(MinValue(15, 4, 1, -55));

            TrySumIfOdd(1, 3, out int result);
            Console.WriteLine(result);

            //Homework Extra

            Repeat("str", 4, out string stringX);
            Console.WriteLine(stringX);
        }

        static void Repeat(string str1, int x, out string strings)
        {
            string str2 = str1;
            for (int i = 1; i < x; i++)
            {
                str2 = str1 + str2;
            }
            strings = str2;
        }


        static int MaxValue(int x, int y)
        {
            return Math.Max(x, y);
        }

        static int MaxValue(int x, int y, int z)
        {
            if (x > y)
            {
                return Math.Max(x, z);
            }
            return Math.Max(y, z);
        }   
        static int MaxValue(int x, int y, int z,int q)
        {
            int a = Math.Max(x, y);
            int b = Math.Max(z, q);
            return Math.Max(a, b);
        }

        static int MinValue(int x, int y)
        {
            return Math.Min(x, y);
        }

        static int MinValue(int x, int y, int z)
        {
            if (x < y)
            {
                return Math.Min(x, z);
            }
            return Math.Min(y, z);
        }       
        static int MinValue(int x, int y, int z, int q)
        {
            int a = Math.Min(x, y);
            int b = Math.Min(z, q);
            return Math.Min(a, b);
        }

        static bool TrySumIfOdd(int x,int y,out int result)
        {
            int sum = 0;

            for (int i = x; i < y + 1; i++)
            {
                sum += i;
            }

            result = sum;
            if (sum % 2 == 0)
            {
                return true;         
            }
            else
            {
                return false;
            }

        }













    }
}
