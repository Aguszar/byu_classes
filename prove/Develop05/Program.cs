using System;

class Program
{

    
    static void Main(string[] args)
    {
        Screen screen =  new Screen();
        screen.ShowMenu();

        string option = Console.ReadLine();

        switch (option){
            
            // Breathing
            case "1":
                BreathActivity b = new BreathActivity();
                

            default:
                ;
        }



    }
}