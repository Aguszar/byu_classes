class Comment{
    private string _username;
    private string _text;


    public Comment(string username, string text){
        _username = username;
        _text = text;
    }

   public void GetText(){
        Console.WriteLine(_text);
   }

   public void GetUsername(){
        Console.WriteLine(_username);
   }
}