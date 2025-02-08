using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    
    static void Main(string[] args)
    {
        void runActivity(Activity activity){
            Console.WriteLine("Welcome to the " + activity.GetTitle());
            Console.WriteLine("");
            Console.WriteLine(activity.GetDescription());
            Console.WriteLine("");
            Console.WriteLine("How long, in seconds, would you like for your session?");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine("/nPreparing to start.../n");
            Pause(3);
            return time;

    


            void Pause(int seconds)
{
    for (int i = 0; i < seconds; i++)
    {
        Console.Write(".", Console.CursorLeft = Console.WindowWidth - 1);
        Thread.Sleep(1000); 
    }
    Console.WriteLine();  
}

            

        };

        Breathing breathingActivity = new Breathing();
        Reflecting reflectingActivity = new Reflecting();
        Listing listingActivity = new Listing();



        bool _isrunning = true;
        while(_isrunning){

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing actiity");
            Console.WriteLine("  2. Start reflecting activity:");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string response = Console.ReadLine();
        
            if (response == "1")
            {

                runActivity(breathingActivity);

            }
            else if (response == "2")
            {

                runActivity(reflectingActivity);
               
            }
            else if (response == "3")
            {
                runActivity(listingActivity);
            }
            else if (response == "4")
            {
                _isrunning=false;
            }
            else
            {
                Console.WriteLine("Sorry wrong response please enter a number between 1 and 4.");
            }


        }

        
    }
       

}
