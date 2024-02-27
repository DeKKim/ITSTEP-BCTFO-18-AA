using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Translator
{
    private Dictionary<string, string> translations;
    private string dictionaryFilePath = "C:\\Users\\kacha\\OneDrive\\Desktop\\HTM.CSS.JS\\dictionary.txt";

    public Translator()
    {
        LoadDictionary();
    }

    private void LoadDictionary()
    {
        translations = File.ReadAllLines(dictionaryFilePath)
            .Select(line => line.Split(','))
            .ToDictionary(parts => parts[0].Trim(), parts => parts[1].Trim());
    }

    private void SaveDictionary()
    {
        File.WriteAllLines(dictionaryFilePath, translations.Select(kv => $"{kv.Key}, {kv.Value}"));
    }

    public void Translate()
    {
        Console.WriteLine("Choose a language pair (1. Georgian-English, 2. Georgian-Russian, 3. English-Georgian, 4. Russian-Georgian):");
        int choice = int.Parse(Console.ReadLine());
        string[] languages = { "Georgian", "English", "Russian" };
        string langFrom = languages[(choice - 1) / 2];
        string langTo = languages[choice % 2];

        Console.Write($"Enter A Word in {langFrom}: ");
        string word = Console.ReadLine().Trim();

        if (translations.ContainsKey(word))
        {
            Console.WriteLine($"Translation in {langTo}: {translations[word]}");
        }
        else
        {
            Console.WriteLine("Translation not found.");
            Console.Write($"Enter translation in {langTo}: ");
            string translation = Console.ReadLine().Trim();
            translations[word] = translation;
            SaveDictionary();
            Console.WriteLine("Translation added.");
        }
    }
}

class Program
{
    static void Main()
    {
        Translator translator = new Translator();
        while (true)
        {
            translator.Translate();
            Console.WriteLine("Translate another word? (Y/N)");
            if (Console.ReadLine().ToUpper() != "Y")
            {
                break;
            }
        }
    }
}