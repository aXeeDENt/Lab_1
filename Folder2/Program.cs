using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace Lab_1
{
    public class FileReader
    {
        public String ReadFileIntoString(String path)
        {
            return File.ReadAllText(path);
        }
    }
    public class TextData
    {
        public string fileName;
        public string text;
        public int numberOfVowels;
        public int numberOfConsonants;
        public int numberOfLetters;
        public int numberOfSentences;
        public string longestWord;
        public TextData(string fileName, string text)
        {
            this.fileName = fileName;
            this.text = text;
            TextAnalysis();
        }
        public void TextAnalysis()
        {
            var words = text.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            longestWord = "";
            numberOfVowels = 0;
            numberOfConsonants = 0;
            numberOfLetters = 0;
            string vowels = "EUIOAeuioa";
            string consonants = "QWRTYPSDFGHJKLZXCVBNMqwrtypsdfghjklzxcvbnm";
            foreach (char letter in text)
            {
                if (char.IsLetter(letter)) numberOfLetters++;
                if (vowels.Contains(letter)) numberOfVowels++;
                if (consonants.Contains(letter)) numberOfConsonants++;
            }
            foreach (var word in words)
            {
                if (word.Length > longestWord.Length) longestWord = word;
            }
            numberOfSentences = Regex.Matches(text, @"(?<![!?])([.!?])").Count;
        }
            public override string ToString()
            {
                return $"File Name: {fileName}\n" +
                    $"Text: {text}\n" +
                    $"Number of Vowels: {numberOfVowels}\n" +
                    $"Number of Consonants: {numberOfConsonants}\n" +
                    $"Number of Letters: {numberOfLetters}\n" +
                    $"Number of Sentences: {numberOfSentences}\n" +
                    $"Longest Word: {longestWord}";
            }
        }
    class Program
    {
        static void Main(string[] args)
        { 
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide the path to the .txt file:");
                return;
            }

            foreach (string filePath in args)
            {
                string fileContent = new FileReader().ReadFileIntoString(filePath);
                TextData textData = new TextData(Path.GetFileName(filePath), fileContent);
                Console.WriteLine(textData);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
