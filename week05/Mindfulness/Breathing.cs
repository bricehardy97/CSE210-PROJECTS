class Breathing: Activity{

    public Breathing ()
        :base(
                "Breathing Activity",
                "This activity will help you relax by walking your way through breathing in and out slowly. Clear your mind and focus on your breathing."
            )
    {
         // constructor function body
    }
 
    public override void Run() {
        Console.WriteLine("We are running the Breathing activity!");

        // print out initial breaht message

        // wait a second
        // porint out next breath message
        // maybe this is all in a while loop with a boolean to stop it after a certain amount of seconds
    }


}