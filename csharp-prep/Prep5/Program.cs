using System;

class Program
{
    static void DisplayWelcome(){
        Console.WriteLine("Welcome :)");
    } 

    static string PromptUserName(){
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    } 

    static int PromptUserNumber(){
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();
        return int.Parse(num);
    }

    static int SquareNumber(int num){
        return num*num;
    }


    static void DisplayResult(string name, int num){
        Console.WriteLine($"{name}, you number squared is {num}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        num = SquareNumber(num);
        DisplayResult(name, num);
    }
}