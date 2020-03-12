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
            var wordsWithTH = words.Where(words => words.Contains("th")); // select each word where the world contains th
            foreach (var word in wordsWithTH) { Console.WriteLine(word); }
            Console.WriteLine("\n==== End problem 1 =======");

            words = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike", "Duplicate", "Duplicate" };
            var wordsWithoutDuplicates = words.Distinct(); // get a list of unique strings
            foreach (var word in wordsWithoutDuplicates) { Console.WriteLine(word); }
            Console.WriteLine("\n==== End problem 2 =======");

            List<string> studentAsStrings = new List<string>() { "80,100,92,89,65", "93,81,78,84,69", "73,88,83,99,64", "98,100,66,74,55" };
            var ArrayOfDouble = studentAsStrings.Select(student => student.Split(',') // select each student and seperate each number at the ,
                                                                          .Select(grades => Convert.ToDouble(grades))) // select the number convert it to double
                                                                          .Select(student => student.Where(grade => grade != student.Min())) // select all students grades that arent the lowest
                                                                          .Select(grades => grades.Average()) // get the average of all the grades average the grades.
                                                                          .Average();// get the average of those averages. 86.125 
            Console.WriteLine(ArrayOfDouble);
            Console.WriteLine("\n==== End problem 3 =======");

            string  newWord = "Terrill";
            var ascending = newWord.ToUpper().GroupBy(letter => letter).OrderBy(letter => letter.Key).ToDictionary(grp => grp.Key, grp => grp.Count());
            foreach (var item in ascending)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n==== End problem 4 =======");
            Console.ReadKey();
        }
    }
}


 