using System;
namespace cal
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string operation;
            int answer;


            Console.Write("Enter the first number : ");
            firstNum = Convert.ToInt32(Console.ReadLine());


            Console.Write("Now enter your second number : ");
            secondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ok now enter your operation ( x , / , +, -) ");
            operation = Console.ReadLine();


            switch (operation)
            {
                case "*":
                    answer = firstNum * secondNum;
                    break;
                case "/":
                    answer = firstNum / secondNum;
                    break;
                case "+":
                    answer = firstNum + secondNum;
                    break;
                case "-":
                    answer = firstNum - secondNum;
                    break;
                default:
                    answer = 0;
                    break;

            }

            Console.WriteLine(firstNum.ToString() + " " + operation + " " + secondNum.ToString() + " = " + answer.ToString());
        }
    }
}