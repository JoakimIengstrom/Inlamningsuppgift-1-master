using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Modules.Browser
{
    class WordHandler
    {
        public static string[] SplitTextIntoWords(string text)
        {
            var words = text.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            return words;
        }

        public static string[] GetTopTenMostFrequent(string[] words)
        {
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word] += 1;
                else
                    wordCount[word] = 1;
            }

            var tenMostCommon = new string[10];
            for (int i = 0; i < 10; i++)
            {
                var highest = int.MinValue;
                var word = "";
                foreach (var keyValue in wordCount)
                {
                    if (keyValue.Value <= highest)
                    {
                        word = keyValue.Key;
                        highest = keyValue.Value;
                    }
                }

                wordCount.Remove(word);
                tenMostCommon[i] = word;
            }

            return tenMostCommon;
        }
    }
}
