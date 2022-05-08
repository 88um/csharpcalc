using System;

public class Calc
{
    public static double answer;
    public static void Main()
    {
        while (true)
        {
            double number1 = input("[+] Enter first number: ");
            string operate = sinput("[+] Enter operator ( +, -, *, / ) : ");
            double number2 = input("[+] Enter second number: ");
            switch (operate)
            {
                case "+":
                    answer = add(number1, number2);
                    break;
                case "-":
                    answer = subtract(number1, number2);
                    break;
                case "*":
                    answer = multiply(number1, number2);
                    break;
                case "/":
                    answer = divide(number1, number2);
                    break;
                default:
                    Console.WriteLine("[!] Invalid Operator Choice!"); Thread.Sleep(5000);
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine($"\n[-] Your answer is {answer}!");
            Thread.Sleep(5000);
            Console.Clear();
        }

    }
    public static double input(string args)
    {
        Console.Write(args);
        return double.Parse(Console.ReadLine());
    }

    public static string sinput(string args)
    {
        Console.Write(args);
        return (Console.ReadLine());
    }
    public static double add(double num1, double num2)
    {
        return (num1 + num2);
    }

    public static double subtract(double num1 , double num2)
    {
        return (num1 - num2);
    }


    public static double multiply(double num1, double num2)
    {
        return (num1 * num2);
    }

    public static double divide(double num1, double num2)
    {
        return (num1/num2);
    }
}
