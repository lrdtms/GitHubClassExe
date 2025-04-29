// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();
        
        int wordCount = LanguageFunctions.GetWordCountInSentence(sentence);
        Console.WriteLine($"Number of words in the sentence: {wordCount}");
        Console.ReadKey();
    }
}

