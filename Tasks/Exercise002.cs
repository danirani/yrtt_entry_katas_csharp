using System;
using System.Diagnostics;
using System.Linq;

// The clock shows 'h' hours, 'm' minutes and 's' seconds after midnight.
// Your task is to make the 'past' function return the time converted to milliseconds.
// More examples in the test cases below.

namespace TechReturners.Tasks
{
    public class Exercise002
    {
        public static int Past(int h, int m, int s)
        {
            // convert the hours h, minutes m and seconds s into 
            // the total number of seconds. Multiply this total
            // by 1000 to obtain the total number of milliseconds
            // elapsed after midnight.

            int totalSeconds = (h * 60 * 60) + (m * 60) + s;
            int totalMilliseconds = totalSeconds * 1000;
            
            return totalMilliseconds;
        }
    }
}

