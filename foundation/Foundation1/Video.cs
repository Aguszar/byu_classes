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

    public int CountComments(){
        return _comments.Count;
    }
    public void ShowAllComments(){
        foreach(Comment com in _comments){
            com.GetUsername();
            com.GetText();
            Console.WriteLine();
        }
    }
}