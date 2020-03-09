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
            Console.WriteLine();

            words = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike", "Duplicate", "Duplicate" };
            var wordsWithoutDuplicates = words.Distinct();
            foreach (var word in wordsWithoutDuplicates) { Console.WriteLine(word); }
            Console.WriteLine();

            List<string> studentAsStrings = new List<string>(){ "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            var ArrayOfDouble = studentAsStrings.Select(student => student.Split(',')
                                                                          .Select(grades => Convert.ToDouble(grades)))
                                                                          .Select(student => student.Where(grade => grade != student.Min()))
                                                                          .Select(grades => grades.Average())
                                                                          .Average();
            Console.WriteLine(ArrayOfDouble);
            Console.ReadKey();
        }

        
    }
}
