using System.Transactions;

class Video
{
    public string _title;
    public string _author;

    public int _length;
    public List <Comment> _comments;
    public Video(string someTitle, string someAuthor, int someLength){
        _title = someTitle;
        _author = someAuthor;
        _length = someLength;
        _comments = new List<Comment>();
    }
    public void Display(){
        Console.WriteLine("Title: " + _title);
        Console.WriteLine("Author:" + _author );
        Console.WriteLine("Length: " + _length);
        Console.WriteLine("Number of comments: " + _comments.Count);
        Console.WriteLine("");
        // Console.WriteLine(_comments[0].Display())

        for(int i = 0; i < _comments.Count; i++)
        {
            _comments[i].Display();
        }
    }

    //public RETURN_TYPE NAME() { }
    public void SayHello() {
        Console.WriteLine("Hello! I love this video by:" + _author);
    }

    
    public int GetNumberOfComments() {
        return _comments.Count;
    }

    public string GetTitleAndAuthor() {
        return _title + " " + _author;
    }
    
    
}