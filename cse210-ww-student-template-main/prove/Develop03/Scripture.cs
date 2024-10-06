class Scripture{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text){
        _reference = reference;
        foreach(string w in text.Split(" ")){
            Word word = new Word(w);
            _words.Add(word);
        } 
    }

    public void HideRandomWords(int numbreToHide){
        Random rand = new Random();

        rand.Next(0, _words.Count);
    }

    public string GetDisplayText(){
        return "";
    }

    public bool IsCompletlyHidden(){
        return false;
    }
}