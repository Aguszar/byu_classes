using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is the magic number ?");
        string target_inp = Console.ReadLine();
        int target = int.Parse(target_inp); 

        bool found = false;
        while (!found){
            Console.Write("What is your guess ?");
            string number_input = Console.ReadLine();
            int number = int.Parse(number_input);

            if(number == target){
                found = true;
                Console.Write("You found it !!");
            }else{
                if(number < target){
                    Console.WriteLine("Higher");
                }else{
                    Console.WriteLine("Lower");
                }
            }
        }

        


    }
}