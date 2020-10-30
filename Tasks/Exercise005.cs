using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;

// Introduction
// The wave (known as the Mexican wave in the English-speaking world outside North America) is an example of metachronal rhythm achieved in a packed 
// stadium when successive groups of spectators briefly stand, yell, and raise their arms. Immediately upon stretching to full height, the spectator 
// returns to the usual seated position.

// The result is a wave of standing spectators that travels through the crowd, even though individual spectators never move away from their seats. 
// In many large arenas the crowd is seated in a contiguous circuit all the way around the sport field, and so the wave is able to travel continuously 
// around the arena; in discontiguous seating arrangements, the wave can instead reflect back and forth through the crowd. When the gap in seating is narrow, 
// the wave can sometimes pass through it. Usually only one wave crest will be present at any given time in an arena, although simultaneous, counter-rotating 
// waves have been produced. (Source Wikipedia)

// Task
// In this simple Kata your task is to create a function that turns a string into a Mexican Wave. You will be passed a string and you must return that string in an array where an uppercase letter is a person standing up. 

// Rules
//  1.  The input string will always be lower case but maybe empty.
//  2.  If the character in the string is whitespace then pass over it as if it was an empty seat
// Example
// wave("hello") => ["Hello", "hEllo", "heLlo", "helLo", "hellO"]

namespace TechReturners.Tasks
{
    public class Exercise005
    {
        public static List<string> Wave(string inputString)
        {
            List<string> waveList = new List<string>();
            
            for (int i = 0; i<inputString.Length; i++)
            {
                // loop through all the character positions in the input string.

                // create a list of the characters that form the input string
                // because C# String objects are immutable and cannot be amended.

                char[] charList = inputString.ToCharArray();

                // if the current character is a space, then do not process 
                // and continue onto the next character position.
                
                if (Char.IsWhiteSpace(charList[i]))
                {
                    continue;
                }

                // set the current character to uppercase.

                charList[i] = char.ToUpper(charList[i]);

                // join the amended characters in the list to form a 
                // single word and add it to the wave sequence list.

                waveList.Add(string.Join("", charList));
            }

            // return the full wave sequence as a list.

            return waveList;
        }
    }
}

