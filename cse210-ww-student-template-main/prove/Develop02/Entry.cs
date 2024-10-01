class Entry{
    public string date;
    public string promptText;
    public string entryText;

    public void Display(){
        Console.WriteLine($"{date} - {entryText}");
    }
}
