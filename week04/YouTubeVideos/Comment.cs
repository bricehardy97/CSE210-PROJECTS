class Comment
{
    public string _name;
    public string _text;

    public void Display(){
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Comment: "+ _text);
        Console.WriteLine("");
    }
    public Comment(string someName, string someText){
        _name = someName;
        _text = someText;
    }
}