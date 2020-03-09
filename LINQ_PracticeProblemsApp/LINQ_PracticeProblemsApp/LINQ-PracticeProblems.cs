using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_PracticeProblemsApp
{
    public class LINQ_PracticeProblems
    { 
        public static List<string> words;

        public static void Exe()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var wordsWithTH = words.Where(words => words.Contains("th")); 
            foreach (var word  in wordsWithTH){ Console.WriteLine(word); }

            words = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var wordsWithoutDuplicates = words.Distinct();
            foreach (var word in wordsWithTH) { Console.WriteLine(word); }

            Console.WriteLine();
            Console.ReadKey();

        }

        
    }
}
