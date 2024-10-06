using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Scripture Memorizer !!");
        
        string book = "1 Nephi";
        int chap = 3;
        int verse = 5;


        string text = "I will do what the lord says what i got to do";

        Reference refe = new Reference(book, chap,verse);

        Scripture scrip = new Scripture(refe, text);
        int i = 0;
        while (! scrip._IsCompletlyHidden){
            
            Console.WriteLine(scrip.GetDisplayText());
            Console.WriteLine("press enter to continue");
            Console.ReadLine();
            scrip.HideRandomWords(3);
            i++;
 
        }

    }
}