using System;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;

class Calculator
{
    //integer addition
    public int addition(int a, int b)
    {
        return a + b;
    }

    //double additon
    public double addition(double a, double b)
    {
        return a + b;
    }

    //integer substraction
    public int substitution(int a, int b)
    {
        return a - b;
    }

    //double substraction
    public double substitution(double a, double b)
    {
        return a - b;
    }

    //integer multiplication
    public int multiplication(int a, int b)
    {
        return a * b;
    }

    //double multiplication
    public double multiplication(double a, double b)
    {
        return a * b;
    }

    //integer division
    public int division(int a, int b)
    {
        return a / b;
    }

    //double divition
    public double division(double a, double b)
    {
        return a / b;
    }

    public static void Main(String[] args)
    {
        Console.WriteLine("Welcome to the commandline calculator App\nYour simple Calculator for day to day life");
        try
        {
            Calculator cal = new Calculator();
            bool state = true;
            do
            {
                Console.WriteLine("1.Do mathematical operation\nonly + -*/ allowed, both numbers");
                Console.WriteLine("2.Exit");
                Console.WriteLine("Enter the choice: ");
                String input = Console.ReadLine();
                int inputA = Convert.ToInt32(input);
                if(inputA == 1)
                {
                    Console.WriteLine("Enter the first number");
                    String numA = Console.ReadLine();
                    Console.WriteLine("Enter the second number");
                    String numB = Console.ReadLine();

                    if(int.TryParse(numA, out int operandA) && int.TryParse(numB, out int operandB))
                    {
                        Console.WriteLine("Enter the operator: ");
                        String symbolic = Console.ReadLine();
                        int result = 0;
                        switch (symbolic)
                        {
                            case "+":
                                result = cal.addition(operandA, operandB);
                                Console.WriteLine("= " + result);
                                break;
                            case "-":
                                result = cal.substitution(operandA, operandB);
                                Console.WriteLine("= " + result);
                                break;
                            case "*":
                                result = cal.multiplication(operandA, operandB);
                                Console.WriteLine("= " + result);
                                break;
                            case "/":
                                result = cal.division(operandA, operandB);
                                Console.WriteLine("= " + result);
                                break;
                        }
                    }
                    else if (double.TryParse(numA, out double operandC) && double.TryParse(numB, out double operandD))
                    {
                        Console.WriteLine("Enter the operator: ");
                        String symbolic = Console.ReadLine();
                        double resultDouble = 0;
                        switch (symbolic)
                        {
                            case "+":
                                resultDouble = cal.addition(operandC, operandD);
                                Console.WriteLine("= " + resultDouble);
                                break;
                            case "-":
                                resultDouble = cal.substitution(operandC, operandD);
                                Console.WriteLine("= " + resultDouble);
                                break;
                            case "*":
                                resultDouble = cal.multiplication(operandC, operandD);
                                Console.WriteLine("= " + resultDouble);
                                break;
                            case "/":
                                resultDouble = cal.division(operandC, operandD);
                                Console.WriteLine("= " + resultDouble);
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Type doesnt match try again!!!");
                    }
                }
                else if(inputA == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\x1b[3J");
                    Console.WriteLine("Thank you for using us!!!!!");
                    state = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (state);
        } catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}