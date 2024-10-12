class Video{
    
    private string _title;
    private string _author;

    // seconds
    private int _length; 
    List<Comment> _comments = [];

    public Video(string title, string author, int length){
        _title = title;
        _author = author;
        _length = length;
    }

     public void AddComment(Comment comment){
        _comments.Add(comment);
    }

    public void GetTitle(){
        Console.WriteLine(_title);
    }

    
    public void GetAuthor(){
        Console.WriteLine(_author);
    }

    public void GetLength(){
        Console.WriteLine(_length);
    }

    public int CountComments(){
        return _comments.Count;
    }
    public void ShowAllComments(){
        foreach(Comment com in _comments){
            com.GetUsername();
            com.GetText();
        }
    }
}