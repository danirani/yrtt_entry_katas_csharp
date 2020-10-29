using System;
using System.Collections.Generic;
using System.Diagnostics;

// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
// Leave punctuation marks untouched.

namespace TechReturners.Tasks
{
    public class Exercise004
    {
        public static string PigIt(string inputText)
        {
            List<string> sentence = new List<string>();

            string word="";
            string punc = "";

            foreach (var letter in inputText)
            {
                if(letter == ' ')
                {
                    sentence.Add(ProcessWord(word)+punc+" ");
                    word = "";
                    punc = "";
                }
                else if(char.IsPunctuation(letter))
                {
                    // preserve punctuation
                    punc += letter;
                }
                else
                {
                    // store alphanumeric chars, not punctuation or spaces
                    word += letter;
                }
            }

            // check for the final word on EOL

            if (word.Length > 0)
            {
                sentence.Add(ProcessWord(word)+punc);
            }

            //Debug.WriteLine("<{0}> <{1}>",inputText,string.Join("",sentence));

            return string.Join("", sentence);
        }

        static string ProcessWord(string rawWord)
        {
            // receive a raw word as input and amend it
            // such that the first letter is moved to the end.
            // Append "ay" to the amended word and return the result.

            string remaining = "";

            if (rawWord.Length == 1)
            {
                remaining = rawWord;
            }
            else
            {
                remaining = rawWord.Substring(1) + rawWord.Substring(0, 1);
            }

            return remaining + "ay";
        }
    }
}

