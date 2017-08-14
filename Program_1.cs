using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_do_while_Гаевая_
{
    class Program
    {
        static void Main(string[] args)
        { /* Повторение:
            1.Пользователь вводит число. Вывести факториал числа.
            Факториал числа представляет собой произведение всех натуральных чисел от 1 до этого числа включительно. 
            Console.WriteLine("Please enter number");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for(int i=number;i>1;i--)
            {
                factorial *= i;               
            }
            Console.WriteLine(factorial);
            2.Найти индексы одинаковых значений 2 - х разных масовов. массив задается пользователем любым удобным для вас способом.
            int[] nums1 = new int[4];
            int[] nums2 = new int[4];
            for (int i=0;i<4;i++)
            {
                Console.WriteLine("Please input number"+(i + 1)+ "from first array");
                nums1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Please input number" + (i + 1) + "from second array");
                nums2[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<4;i++)
                if(nums1[i]==nums2[i])
                {
                    Console.WriteLine(i + 1);
                }
           // 3.Написать калькулятор с возможными операциями(+,-,/,*).
            
            Console.WriteLine("Please enter number1");
            int Var1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number2");
            int Var2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter operation");
            string str = Console.ReadLine();
            switch (str)
            {
                case "plus":
                    Plus(Var1, Var2);
                    break;
                case "minus":
                    Minus(Var1, Var2);
                    break;
                case "multiplication":
                    Multiplication(Var1, Var2);
                    break;
                case "division":
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



            
           // While /do while
         // 1.Пользователь должен вводить числа по очереди, до тех пор пока разница введеных двух предыдущих чисел не превысит 10.*/

            while(int n - (n - 1) > 10);
            {
                Console.WriteLine("Enter number:  ");
                 n = int.Parse(Console.ReadLine());
            }
     

        }   
    }
}
