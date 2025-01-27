using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        
        string scriptureReference = "John 3:16";
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        
        List<string> words = scriptureText.Split(' ').ToList();
        List<string> hiddenWords = new List<string>(); 

        bool programRunning = true;

        while (programRunning)
        {
            Console.Clear();
    
            DisplayScriptureWithHiddenWords(scriptureReference, scriptureText, hiddenWords);

            
            Console.WriteLine("Press Enter to hide more words or type 'quit' to end.");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "quit")
            {
                programRunning = false;
            }
            else if (userInput == "")
            {
                
                HideRandomWord(words, hiddenWords);
            }
        }

        
        Console.Clear();
        DisplayScriptureWithHiddenWords(scriptureReference, scriptureText, hiddenWords);
        Console.WriteLine("All words have been hidden. The program will now exit.");
    }

    
    static void DisplayScriptureWithHiddenWords(string reference, string text, List<string> hiddenWords)
    {
        Console.WriteLine($"Scripture Reference: {reference}");

        string[] words = text.Split(' ');
        List<string> displayedWords = new List<string>();

        foreach (var word in words)
        {
            if (hiddenWords.Contains(word.ToLower())) 
            {
                displayedWords.Add(new string('_', word.Length)); // 
            }
            else
            {
                displayedWords.Add(word); 
            }
        }

        
        Console.WriteLine(string.Join(" ", displayedWords));
    }

    
    static void HideRandomWord(List<string> words, List<string> hiddenWords)
    {
        
        var availableWords = words.Where(w => !hiddenWords.Contains(w.ToLower())).ToList();

        if (availableWords.Any())
        {
            Random random = new Random();
            int randomIndex = random.Next(availableWords.Count);
            string wordToHide = availableWords[randomIndex];

            
            hiddenWords.Add(wordToHide.ToLower());

            Console.WriteLine($"Word hidden: {wordToHide}");
        }
        else
        {
            Console.WriteLine("All words are already hidden.");
        }
    }
}