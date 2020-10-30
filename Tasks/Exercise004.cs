using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string inputText)
        {
            List<string> sentence = new List<string>();

            string word = ""; // hold letters in a string buffer

            foreach (var letter in inputText)
            {
                if(Char.IsWhiteSpace(letter))
                {
                    // space has been encountered so process the word
                    // i.e. move first char to last position and add "ay"
                    // store the result in the sentence list.

                    sentence.Add(ProcessWord(word));
                    
                    // preserve sentence spacing by adding every space to the sentence list

                    sentence.Add(" ");

                    // clear the letter buffer

                    word = "";
                }
                else
                {
                    // store all characters apart from white space in a string buffer.
                    word += letter;
                }
            }

            // process the final word (if any) on EOL

            if (word.Length > 0)
            {
                sentence.Add(ProcessWord(word));
            }

            return string.Join("", sentence);
        }

        static string ProcessWord(string word)
        {
           
            string finalWord="";

            // find the last input string index of the character before any 
            // puntuation; this will be the full word length-1 if there are no 
            // punctuation characters.

            int endOfWord = FindEndOfWord(word);

            if(endOfWord >= 0)
            {
                // the input word is not empty so move the first character to the end 
                // (before any punctuation) and add "ay" to the amended word.

                finalWord = word.Substring(1, endOfWord) + word.Substring(0, 1)+"ay";
            }
            
            // add the remaining punctuation (if any)

            finalWord += word.Substring(endOfWord+1);
            
            return finalWord;
        }

        static int FindEndOfWord(string word)
        {
            // return the string index of the last contiguous non-punctuation character.
            // e.g. "hand#" returns 3, "A" returns 0, and "!" returns -1.
        
            int lastLetter = -1;

            foreach(var c in word)
            {
                if (char.IsPunctuation(c)) {
                    break;
                }

                lastLetter++;
            }

            return lastLetter;
        }
    }
}

