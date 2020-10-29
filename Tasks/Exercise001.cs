using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// In this Kata, you will be given an array of numbers in which two numbers occur once and the rest occur only twice. 
// Your task will be to return the sum of the numbers that occur only once.
// For example, repeats([4,5,7,5,4,8]) = 15 because only the numbers 7 and 8 occur once, and their sum is 15.
// More examples in the test cases below.

// Good luck!

namespace TechReturners.Tasks
{
    public class Exercise001
    {
        public static int Singles(List<int> source)
        {
            var groupCount = source.GroupBy(digit => digit);

            Debug.Print("-----------------");

            foreach (var obj in groupCount)
            {
                Debug.WriteLine("{0} , {1}", obj.Key, obj.Count());
            }

            int totalOfSingles = groupCount
               .Where(group => group.Count() == 1)
               .Select(unique => unique.Key).Sum();

            Debug.WriteLine("{0} = {1}", string.Join(",", source), totalOfSingles);

            return totalOfSingles;
        }
    }
}