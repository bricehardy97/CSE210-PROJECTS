using System;
using System.Formats.Asn1;
using System.Net;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
         List<JournalEntry> entries = new List<JournalEntry>();
        bool programsRunning = true;
        while(programsRunning)
        {
            Console.WriteLine("Please pick one of the following");
            Console.WriteLine("1-Write");
            Console.WriteLine("2-Display");
            Console.WriteLine("3-Load");
            Console.WriteLine("4-Save");
            Console.WriteLine("5-Quit");
            Console.WriteLine("What would you like to do?");
            string userinput = Console.ReadLine();
            
            
            if (userinput =="1")
            {
                Console.WriteLine("You chose option 1 ");
                string[] prompts = {
                    "Who is the most interesting person I interacted with today?",
                     "What was the best part of your day?",
                     "How did I see the hand of the lord in my life today?",
                     "What was the strongest emotion I felt today?",
                     "If I had one thing I could do over today, what would it be?"
                };// Give user random prompt.
                
                Random generator = new Random();
                int promptIndex = generator.Next(0,4);
                Console.WriteLine (prompts[promptIndex]);

                // Get input from user and save// Journal entry includes the date, the prompt and response.

                string journalResponse =Console.ReadLine();
                JournalEntry entry = new JournalEntry();
                entry._entry =journalResponse;
                DateTime theCurrentTime = DateTime.Now;
                string dateText= theCurrentTime.ToShortDateString();
                entry._date =dateText;
                entry._prompt=prompts[promptIndex];
                entries.Add(entry);
            }
            else if (userinput =="2")
            {
                Console.WriteLine("You chose option 2 ");
                // Display the message from previous entries.
               for (int i = 0; i < entries.Count; i++)
               {
                 Console.WriteLine ();
                Console.WriteLine (entries[i]._entry);
                Console.WriteLine (entries[i]._prompt);
                Console.WriteLine (entries[i]._date);
                 Console.WriteLine ();
                
               }
            }
            else if (userinput =="3")
            {
                Console.WriteLine("You chose option 3 ");
                Console.WriteLine("What is the file name?");
                string filename = Console.ReadLine();
                try
        {
            if (File.Exists(filename))
            {
                var fileEntries = File.ReadAllLines(filename);
                entries.Clear(); // Clear current entries before loading new ones.

                foreach (var line in fileEntries)
                {
                    // Assuming each entry is saved on a single line (could adjust based on your format)
                    var entryParts = line.Split(" | "); // Example delimiter, adjust as necessary
                    if (entryParts.Length == 3)
                    {
                        entries.Add(new JournalEntry
                        {
                            _date = entryParts[0],
                            _prompt = entryParts[1],
                            _entry = entryParts[2]
                        });
                    }
                }

                Console.WriteLine("Entries loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        
            catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }
    
        
            }
            else if (userinput =="4")
            {
                Console.WriteLine("You chose option 4 ");
                Console.WriteLine("What is the name of the file youd like to save?");
                string filename = Console.ReadLine();
                
            try
            {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry._date} | {entry._prompt} | {entry._entry}");
                }
            }
            Console.WriteLine("Entries saved successfully.");
            }
            catch (Exception ex)
            {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
            }
    


            }
            else if (userinput =="5")
            {
                Console.WriteLine("You chose option 5 ");
                programsRunning=false;
                
            }
            else 
            {
                Console.WriteLine("Please try again ");
            }
        }
        
        
    
    }

}
