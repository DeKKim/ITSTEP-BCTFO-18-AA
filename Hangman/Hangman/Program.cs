using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int a = random.Next(1, 6);

        if (a == 1)
        {
            Console.WriteLine("Hint: Yvitelia");
            string word = "banani";
            char[] guessedWord = new char[word.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            bool wordGuessed = false;
            int cda = 0;
            while (!wordGuessed)
            {
                Console.WriteLine(string.Join(" ", guessedWord));

                Console.Write("Sheiyvanet Aso: ");
                char input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool letterFound = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == input)
                    {
                        guessedWord[i] = input;
                        letterFound = true;
                    }
                }

                if (!guessedWord.Contains('_'))
                {
                    wordGuessed = true;
                }

                cda++;

                if (!letterFound)
                {
                    Console.WriteLine("Arasworia! Kidev Scadet");
                }
            }

            Console.WriteLine("Gilocavt! Tqven Warmatebit Gamoicanit Sityva '{0}'  {1} Cdashi.", word, cda);
        }
        else if (a == 2)
        {
            Console.WriteLine("Hint: Am Sasiamovno Nivtierebas Didi Istoria aqvs Da is Mesoamerikuli Kulturebidan Momdinareobs");
            
            string word = "shokoladi";
            char[] guessedWord = new char[word.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            bool wordGuessed = false;
            int cda = 0;
            while (!wordGuessed)
            {
                Console.WriteLine(string.Join(" ", guessedWord));

                Console.Write("Sheiyvanet Aso: ");
                char input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool letterFound = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == input)
                    {
                        guessedWord[i] = input;
                        letterFound = true;
                    }
                }

                if (!guessedWord.Contains('_'))
                {
                    wordGuessed = true;
                }

                cda++;

                if (!letterFound)
                {
                    Console.WriteLine("Arasworia! Kidev Scadet");
                }
            }

            Console.WriteLine("Gilocavt! Tqven Warmatebit Gamoicanit Sityva '{0}'  {1} Cdashi.", word, cda);

        }
        else if (a == 3)
        {
            Console.WriteLine("Hint: Xshirad Am Nivts Samzareuloshi Vxvdebit Da Aramarto Mand");
           
            string word = "dana";
            char[] guessedWord = new char[word.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            bool wordGuessed = false;
            int cda = 0;
            while (!wordGuessed)
            {
                Console.WriteLine(string.Join(" ", guessedWord));

                Console.Write("Sheiyvanet Aso: ");
                char input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool letterFound = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == input)
                    {
                        guessedWord[i] = input;
                        letterFound = true;
                    }
                }

                if (!guessedWord.Contains('_'))
                {
                    wordGuessed = true;
                }

                cda++;

                if (!letterFound)
                {
                    Console.WriteLine("Arasworia! Kidev Scadet");
                }
            }

            Console.WriteLine("Gilocavt! Tqven Warmatebit Gamoicanit Sityva '{0}'  {1} Cdashi.", word, cda);
        }
        else if (a == 4)
        {
            Console.WriteLine("Hint: Chven Mas Yoveldgiurad Viyenebt");
            
            string word = "kompiuteri";
            char[] guessedWord = new char[word.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            bool wordGuessed = false;
            int cda = 0;
            while (!wordGuessed)
            {
                Console.WriteLine(string.Join(" ", guessedWord));

                Console.Write("Sheiyvanet Aso: ");
                char input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool letterFound = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == input)
                    {
                        guessedWord[i] = input;
                        letterFound = true;
                    }
                }

                if (!guessedWord.Contains('_'))
                {
                    wordGuessed = true;
                }

                cda++;

                if (!letterFound)
                {
                    Console.WriteLine("Arasworia! Kidev Scadet");
                }
            }

            Console.WriteLine("Gilocavt! Tqven Warmatebit Gamoicanit Sityva '{0}'  {1} Cdashi.", word, cda);
        }
        else if (a == 5)
        {
            Console.WriteLine("Hint: Am Metals Xshirad Iyeneben Mwedlebi");
            string word = "rkina";
            char[] guessedWord = new char[word.Length];
            for (int i = 0; i < guessedWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            bool wordGuessed = false;
            int cda = 0;
            while (!wordGuessed)
            {
                Console.WriteLine( string.Join(" ", guessedWord));

                Console.Write("Sheiyvanet Aso: ");
                char input = char.ToLower(Console.ReadKey().KeyChar);
                Console.WriteLine();

                bool letterFound = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == input)
                    {
                        guessedWord[i] = input;
                        letterFound = true;
                    }
                }

                if (!guessedWord.Contains('_'))
                {
                    wordGuessed = true;
                }

                cda++;

                if (!letterFound)
                {
                    Console.WriteLine("Arasworia! Kidev Scadet");
                }
            }

            Console.WriteLine("Gilocavt! Tqven Warmatebit Gamoicanit Sityva '{0}'  {1} Cdashi.", word, cda);
        }
    }
}