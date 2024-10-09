class Scripture{
    private Reference _reference;
    private List<Word> _words = [];
    private List<int> _positions = [];

    private bool _IsCompletlyHidden;
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
            _words[_positions[pos]].Hide();
            _positions.RemoveAt(pos);
            
            i++;
        }
        
        if(_positions.Count <= 0){
            _IsCompletlyHidden = true;  
        }
        
    }

    public string GetDisplayText(){
        string t = "";
        foreach (Word w in _words){   
            if(!w.IsHidden()){
                t += " "+w.GetDisplayText(); 
            }else{

                t += " ___";
            }
        }
        return _reference.GetDisplayText() + " " + t;
    }

    public bool IsCompletlyHidden(){
        return _IsCompletlyHidden;
    }

    public void showEverything(){
        int i = 0;
        foreach (Word w in _words){
            w.Show();
            _positions.Add(i);
            i++;
        }
        _IsCompletlyHidden = false;        
    }
}