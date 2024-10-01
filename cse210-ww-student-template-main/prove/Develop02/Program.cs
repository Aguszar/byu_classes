using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        Entry entry = new Entry();
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while(! quit){
            Console.Clear();
            Console.WriteLine("Please select one of the options (1-5): ");
            Console.WriteLine("1. Write\n2. Display\n3. load\n4. Save\n5. Quit ");
            Console.WriteLine("What would you like to do ? ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    List<string> prompts = ["Who was the most interesting person I interacted with today?","What was the best part of my day?","How did I see the hand of the Lord in my life today?","What was the strongest emotion I felt today?","If I had one thing I could do over today, what would it be?"];

                    DateTime theCurrentTime = DateTime.Now;
                    
                    entry.date =  theCurrentTime.ToShortDateString();
                    
                    Random rand = new Random();
                    entry.promptText = prompts[rand.Next(0, prompts.Count)]; // ramdom
                    
                    Console.WriteLine(entry.promptText);
                    entry.entryText = Console.ReadLine();

                    journal.AddEntry(entry);
                    
                    
                    break;
                case "2":
                    
                    
                    Console.ReadLine();
                    break;

                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    quit = true;
                    break;
                default:
                    break;
            }
            
        }


        


        

    }
}