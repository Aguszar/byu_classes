using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
        
        string book = "1 Nephi";
        int chap = 3;
        int verse = 5;


        string text = "I will do what the lord asks me to do";

        Reference refe = new Reference(book, chap,verse);

        Scripture scrip = new Scripture(refe, text);

        string prompt = "abc";
        while (true){
            if(prompt=="quit"){
                break;
            }else{
                Console.Clear();            
                Console.WriteLine("Scripture Memorizer !!");
                Console.WriteLine(scrip.GetDisplayText());
                Console.WriteLine("press enter to continue or enter 'quit'");
                prompt = Console.ReadLine();
                
                
                // hides 2 words every time
                scrip.HideRandomWords(2);
                if (scrip.IsCompletlyHidden()){
                    Console.Clear();
                    Console.WriteLine("Scripture Memorizer !!");
                    Console.WriteLine(scrip.GetDisplayText());
                    Console.WriteLine("press enter to continue or enter 'quit'");
                    prompt = Console.ReadLine();
                    scrip.showEverything();
                }
            }
        }
        
    }
}