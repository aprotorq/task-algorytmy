using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace CountCharacters
{
    class Algorithms
    {
        private string inputString;

        public Algorithms(string userString)
        {
            string sentense = userString.ToUpper();
            string pattern = @"[^0-9A-Z]";
            Console.WriteLine($"number of all characters: {sentense.Length}");
            sentense = Regex.Replace(sentense, pattern, string.Empty);
            this.inputString = sentense;
        }
       
        public void ListAlgorithm()
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            List<char> charList = inputString.ToList();

            List<CharacterModel> occur = new List<CharacterModel>();

            foreach (char c in charList)
            {
                bool isNumber = Char.IsDigit(c);
                int count = charList.Where(x => x.Equals(c)).Count();
                if (occur.FindIndex(o => o.Character == c) == -1)
                {
                    occur.Add(new CharacterModel(c, count));

                }
            }
            Console.WriteLine("Characters by count order:");
            foreach (CharacterModel character in occur.OrderByDescending(order => order.Count))
            {
                Console.WriteLine($"{character}");
            }
            Console.WriteLine("Characters by alphabetical order:");
            foreach (CharacterModel character in occur.OrderBy(o => o.Character))
            {
                Console.WriteLine($"{character}");
            }
            
        }

        public void ArrayAlgorithm() 
        {
            Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            char[] characters = inputString.ToCharArray();
            Array.Sort(characters);

            int distinctCharactersCount = 0;
            char previousChar = '\0';

            foreach (char c in characters)
            {
                if (previousChar != c)
                {
                    distinctCharactersCount++;
                }

                previousChar = c;
            }

            CharacterModel[] charactersInfos = new CharacterModel[distinctCharactersCount];

            int index = 0;

            foreach (char c in characters)
            {
                if (charactersInfos[index] == null)
                {
                    charactersInfos[index] = new CharacterModel( c, 1 );
                    continue;
                }

                if (charactersInfos[index].Character != c)
                {
                    index++;
                    charactersInfos[index] = new CharacterModel( c, 1 );
                    continue;
                }
                else
                {
                    charactersInfos[index].Count++;
                }
            }

            Console.WriteLine("Characters by count order:");

            foreach (CharacterModel info in charactersInfos.OrderByDescending(ci => ci.Count))
            {
                Console.WriteLine(info);
            }
            Console.WriteLine("Characters by alphabetical order:");

            foreach (CharacterModel info in charactersInfos)
            {
                Console.WriteLine(info);
            }
            Console.ReadLine();
        }
    }
}
