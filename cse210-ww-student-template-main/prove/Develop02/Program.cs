using System;
using System.Globalization;


class Entry{
    public string date;
    public string promptText;
    public string entryText;

    public void Display(){
        Console.WriteLine($"{date} - {entryText}");
    }
}
class Journal
{
    public List<Entry> entries;

    public void AddEntry( Entry entry){}

    public void DisplayAll(){}

    public void SaveToFile(string file){}
}

class PromptGenerator{
    public List<string> prompts;

    public string GetRandomPrompt(){
        return "";
    }
}


class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        
        entry.entryText = Console.ReadLine()

    }
}