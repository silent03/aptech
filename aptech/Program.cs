//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace aptech
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter Your Name");
//            string name = Console.ReadLine();

//            Console.WriteLine("Enter Your Father Name");
//            string Fname = Console.ReadLine();

//            Console.WriteLine("Enter Your English Marks");
//            int eng = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Your Bio Marks");
//            int bio = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Your Urdu Marks");
//            int urdu = int.Parse(Console.ReadLine());

//            Console.WriteLine("Enter Your Physics Marks");
//            int phy = int.Parse(Console.ReadLine());

//            int tm = 400;

//            int marks = eng + bio + urdu + phy;
//            double per = (double) marks / tm * 100;

//            Console.WriteLine("Student Name is " + name);
//            Console.WriteLine("Student Father Name is " + Fname);
//            Console.WriteLine("Student Obtained Marks is " + marks);
//            Console.WriteLine("Student Total Marks is " + tm);
//            Console.WriteLine("Student Percentage is {0}% " , per);

//            if (per >= 80)
//            {
//                Console.WriteLine("Student Grade is A+");
//            }

//            else if (per >= 70)
//            {
//                Console.WriteLine("Student Grade is A");
//            }

//            else if (per >= 60)
//            {
//                Console.WriteLine("Student Grade is B");
//            }

//            else if (per >= 60)
//            {
//                Console.WriteLine("Student Grade is c");
//            }

//            else
//            {
//                Console.WriteLine("Student is Fail");
//            }
//            Console.ReadKey();


//        }
//    }
//}

//---------------------CALCULATOR-----------------------

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operation (+, -, *, /): ");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;

        if (operation == '+')
            result = num1 + num2;
        else if (operation == '-')
            result = num1 - num2;
        else if (operation == '*')
            result = num1 * num2;
        else if (operation == '/')
        {
            if (num2 != 0)
                result = num1 / num2;
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Invalid operation.");
            return;
        }

        Console.WriteLine($"{result}");
        Console.ReadLine();
    }
}
