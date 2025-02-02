using System;

class Program
{
    static void Main(string[] args)
    {
      Video myVideo = new Video("The Longest Yard"," Donald Trump ",30);
      Comment LComment= new Comment("Rusty","Wow great video!");
      Comment ZComment= new Comment("Sandy","Looks great!");
      Comment NComment= new Comment("Cole","Smashing!");
      Comment OComment= new Comment("Clark","Could have done better...");
          myVideo._comments.Add(LComment);
          myVideo._comments.Add(ZComment);
          myVideo._comments.Add(NComment);
          myVideo._comments.Add(OComment);
          myVideo.Display();
       
       
      // myVideo._title = "longest yard";
      // myVideo._author = "Donald Trump";
      // myVideo._length = 30;
      // myVideo.Display();

      Video newVideo = new Video("Fishing with my boy"," Bruce Willis",50);
      Comment MComment= new Comment("Fred ","So cute!");
      Comment AComment= new Comment("Josh","Love this!");
      Comment BComment= new Comment("James", "Nice Fish!");
      Comment CComment= new Comment("Cody","Looks like fun!");
       newVideo._comments.Add(MComment);
       newVideo._comments.Add(AComment);
       newVideo._comments.Add(BComment);
       newVideo._comments.Add(CComment);

       newVideo.Display();

      Video theVideo = new Video("Expensive dinners"," Peyton Manning",175);
      Comment DComment= new Comment("Cooper","Looks delicous!");
      Comment EComment= new Comment("Corbin","That much for a steak?");
      Comment FComment= new Comment("Natalie","Can I have some???");
      Comment GComment= new Comment("Andrew","Whats the recipe?");
       theVideo._comments.Add(DComment);
       theVideo._comments.Add(EComment);
       theVideo._comments.Add(FComment);
       theVideo._comments.Add(GComment);
       theVideo.Display();

      Video recentVideo = new Video("Hunting in Africa "," Tom Holland",60);
      Comment HComment= new Comment("Brittany","Wow that elephant is huge!");
      Comment IComment= new Comment("Mike","Where can I purchase these tags?");
      Comment JComment= new Comment("Shiree","Looks so scary!");
      Comment KComment= new Comment("Kaden","Were any animals hurt in your video?");
      Comment myComment = new Comment("Sage", "How many animals can you get?");
       recentVideo._comments.Add(HComment);
       recentVideo._comments.Add(IComment);
       recentVideo._comments.Add(JComment);
       recentVideo._comments.Add(KComment);
       recentVideo.Display();
      // myComment._name = "Brandon";
      // myComment._text = "Here is my comment!!!!!1";
      
     
       
      // Comment earlyComment= new Comment();
      
       
      // Comment recentComment= new Comment();


      // myVideo._comments.Add(newComment);
      //  Console.WriteLine("Name: " + myVideo._comments[0]._name);
      // Console.WriteLine("Comment: "+ myVideo._comments[0]._text);
      // myVideo._comments[0].Display();

      
      // myVideo._comments.Add(myComment);
      // Console.WriteLine("Namet: " + myVideo._comments[1]._name);
      // Console.WriteLine("Comment: "+ myVideo._comments[1]._text);
      // myVideo._comments[1].Display();

    // myVideo.Display();
      // Console.WriteLine(6);
      // int x = 10;
      // Console.WriteLine(x);

      Console.WriteLine(myVideo.GetNumberOfComments());
      // Console.WriteLine(myVideo._comments.Count);

      // myVideo.GetNumberOfComments();
    }
}