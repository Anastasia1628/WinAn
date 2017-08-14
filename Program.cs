using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program

    {
        enum Operation
        {
            Plus,
            Minus,
            Multiplication,
            Division
        }
        static void Main(string[] args)
        {
           
            string[] arr = Numbers();
            int Var1 = int.Parse(arr[1]);
            int Var2 = int.Parse(arr[0]);
            Operation operation = ParseOperation(arr[2]);
            switch (operation)
            {
                case Operation.Plus:
                    Plus(Var1, Var2);
                    break;
                case Operation.Minus:
                    Minus(Var1, Var2);
                    break;
                case Operation.Multiplication:
                    Multiplication(Var1, Var2);
                    break;
                case Operation.Division:
                    Division(Var1, Var2);
                    break;

            }
        }

        static void Plus(int a, int b)
        {
            int c = a + b;
            Console.WriteLine(c);


        }

        static void Minus(int a, int b)
        {
            int c = a - b;
            Console.WriteLine(c);

        }
        static void Multiplication(int a, int b)
        {
            int c = a * b;
            Console.WriteLine(c);

        }
        static void Division(int a, int b)
        {

            int c = a / b;

            Console.WriteLine(c);
        }
        static Operation ParseOperation(string UserValue)
        {
            Operation Plus1 = (Operation)Enum.Parse(typeof(Operation), UserValue);
            return Plus1;
        }
        static string[] Numbers()
        {
            string[] mas = new string[3];
            
            Console.WriteLine("Please enter number1");
            mas[0]= Console.ReadLine();
            Console.WriteLine("Please enter number2");
            mas[1] = Console.ReadLine();
            Console.WriteLine("Please enter operation");
            mas[2] = Console.ReadLine();
            return mas;
        }



    }
}