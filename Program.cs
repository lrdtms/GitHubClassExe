// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        
        int wordCount = WordCounter.CountWords(input);
        Console.WriteLine($"Number of words in the sentence: {wordCount}");
    }
}

public class WordCounter
{
    public static int CountWords(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return 0;

        string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
