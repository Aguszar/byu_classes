class Journal
{
    public List<Entry> entries;

    public void AddEntry( Entry entry){
        entries.Add(entry);
    }

    public void DisplayAll(){
        foreach (Entry e in entries){
            e.Display();    
        }
    }

    public void SaveToFile(string file){
        //// FINISH

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }
}