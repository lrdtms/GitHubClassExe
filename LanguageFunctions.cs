using System;

public class LanguageFunctions
{
    public static int GetWordCountInSentence(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return 0;

        string[] words = sentence.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}