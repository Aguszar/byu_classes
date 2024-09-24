using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers;
        numbers = new List<int>();

        int sum = 0;
        int largest = 0;
        bool is_zero = false;

        while(!is_zero){
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int numb = int.Parse(input);
            numbers.Add(numb);
            sum += numb;

            if(numb > largest)
                largest = numb;

            if(numb==0){
                is_zero = true;
            }
        }

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average number: {sum/numbers.Count}");
        Console.WriteLine($"Largest number: {largest}");
        
    }
}