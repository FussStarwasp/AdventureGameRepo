using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSummarizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = "This is a really really really long and boring text.";
            Console.WriteLine(Summarizer.Summarize(article, 20));

        }
    }
}
