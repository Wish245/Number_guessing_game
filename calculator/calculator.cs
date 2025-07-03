using System;
using System.Runtime.InteropServices;
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
    }
}