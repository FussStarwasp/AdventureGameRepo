using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummarizer
{
    public static class Summarizer
    {
        public static string Summarize(string text, int maxLength)
        {
            if (text.Length <= maxLength)
            {
                return text;
                
            }


            string[] words = text.Split(' ');
            List<string> summarizedText = new List<string>();

            int characterCount = 0;

            foreach(string word in words)
            {
                if (summarizedText.Count == 0)
                {
                    characterCount = word.Length;
                }
                else
                {
                    characterCount += word.Length + 1;
                }
                    
                
                    
                    
                    
                if (characterCount + 1 == maxLength || characterCount == maxLength)
                {
                    summarizedText.Add(word);
                    return string.Join(" ", summarizedText) + "...";
                }

                else
                {
                    if (characterCount <= maxLength)
                    {
                        summarizedText.Add(word);
                        continue;
                    }

                    return string.Join(" ", summarizedText)+"...";

                }

            }
            return string.Join(" ",summarizedText)+"...";

        }
        

    }
}
