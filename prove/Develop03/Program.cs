using System;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
                
        string book = "1 Nephi";
        int chap = 3;
        int verse = 5;


        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";

        Reference refe = new Reference(book, chap,verse);

        Scripture scrip = new Scripture(refe, text);

        string prompt = "abc";
        while (true){
            if(prompt=="quit"){
                break;
            }else{
                Console.Clear();            
        
                // added color to the game title
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Scripture Memorizer !!", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(scrip.GetDisplayText());
                Console.WriteLine("press enter to continue or enter 'quit'");
                prompt = Console.ReadLine();
                
                
                // hides 2 words every time
                scrip.HideRandomWords(2);
                if (scrip.IsCompletlyHidden()){
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Scripture Memorizer !!", Console.ForegroundColor);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(scrip.GetDisplayText());
                    prompt = "quit";
                    // if you want it to go forever, uncomment the code below
                    //Console.WriteLine("press enter to continue or enter 'quit'");
                    //prompt = Console.ReadLine();
                    //scrip.showEverything();
                }
            }
        }
        
    }
}