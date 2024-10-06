class Scripture{
    public Reference _reference;
    public List<Word> _words = [];
    public List<int> _positions = [];

    public bool _IsCompletlyHidden;
    public Scripture(Reference reference, string text){
        _reference = reference;
        _IsCompletlyHidden = false;
        int i = 0;
        string[] words = text.Split(" ");

        foreach(string w in words){
            Word word = new Word(w);
            _words.Add(word);
            _positions.Add(i); 
            i++;            
        } 
        
    }

    public void HideRandomWords(int numberToHide){
        Random rand = new Random();
        int i = 0;
        
        while (i < numberToHide && _positions.Count > 0 && !_IsCompletlyHidden){
            int pos = rand.Next(0, _positions.Count);
            Console.WriteLine(pos + " "+ _positions[pos] +" "+ _words[pos]._text);
            _positions.RemoveAt(pos);
            _words[pos].Hide();
            i++;
        }
        foreach (int num in _positions)
        {
            Console.Write(num+", ");
        }

        Console.WriteLine();

        if(_positions.Count ==0){
            _IsCompletlyHidden = true;  
        }
        
    }

    public string GetDisplayText(){
        string t = "";
        foreach (Word w in _words){   
            if(!w.IsHidden()){
                t += " "+w.GetDisplayText(); 
            }else{
                t += " __";
            }
        }
        return _reference.GetDisplayText() + " " + t;
    }

    public bool IsCompletlyHidden(){
        return _IsCompletlyHidden;
    }
}