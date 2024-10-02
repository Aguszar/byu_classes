using System;
using System.Globalization;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {

        bool quit = false;
        
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        while(! quit){
            Console.Clear();
            Console.WriteLine("Please select one of the options (1-5): ");
            Console.WriteLine("1. Write\n2. Display\n3. load\n4. Save\n5. Quit ");
            Console.WriteLine("What would you like to do ? ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Entry entry = new Entry();

                    DateTime theCurrentTime = DateTime.Now;
                    
                    entry.date = theCurrentTime.ToShortDateString();
                    
                    Random rand = new Random();
                    entry.promptText = promptGen.prompts[rand.Next(0, promptGen.prompts.Count)]; // ramdom
                    
                    Console.Write(entry.promptText+"\n>>");
                    entry.entryText = Console.ReadLine();

                    journal.AddEntry(entry);
                    
                    
                    break;
                case "2":

                
                    journal.DisplayAll();
                    Console.WriteLine("Press enter when finished reading.");
                    Console.ReadLine();
                    break;

                case "3":
                    try{
                        Console.Write("Enter file name: ");
                        string filename = Console.ReadLine();
                        string[] lines = System.IO.File.ReadAllLines(filename);

                        foreach (string line in lines){
                            Console.WriteLine(line);
                        }    
                    }
                    catch (System.IO.FileNotFoundException){
                        Console.WriteLine("Error: File does not exist ");
                    }
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                    break;
                case "4":
                    Console.Write("Enter file name: ");
                    string fileName = Console.ReadLine();

                    foreach (Entry e in journal.entries){
                        File.AppendAllText(fileName, $"{e.date} - {e.promptText}: {e.entryText}\n");   
                    }
                    
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