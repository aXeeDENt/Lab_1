using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Lab_1
{
    public class FileReader
    {
        String readFileIntoString(String path)
        {
            return File.ReadAllText(path);
        }
    }
    public class TextData
    {
        string fileName;
        string text;
        int numberOfVowels;
        int numberOfConsonants;
        int numberOfLetters;
        int numberOfSentences;
        string longestWord;
    }
    class Program
    {
        static void Main(string[] args)
        { 
        }
    }
}
