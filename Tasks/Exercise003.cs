using System;
using System.Diagnostics;
using System.Collections.Generic;

// Scenario
// Several people are standing in a row divided into two teams. The first person goes into team 1, the second goes into team 2, the third goes into team 1, and so on.

// Task
// Given an array of positive integers (the weights of the people), return a new array of two integers, where the first one is the total weight of team 1, and the second one is the total weight of team 2.

// Notes
// Array size is at least 1.
// All numbers will be positive.

// Input >> Output Examples
// rowWeights([13, 27, 49])  ==>  return (62, 27)
// Explanation:
// The first element 62 is the total weight of team 1, and the second element 27 is the total weight of team 2.

// rowWeights([50, 60, 70, 80])  ==>  return (120, 140)
// Explanation:
// The first element 120 is the total weight of team 1, and the second element 140 is the total weight of team 2.

// rowWeights([80])  ==>  return (80, 0)
// Explanation:
// The first element 80 is the total weight of team 1, and the second element 0 is the total weight of team 2.

namespace TechReturners.Tasks
{
    public class Exercise003
    {
        public static int[] RowWeights(int[] allPeopleArray)
        {
            // dictionary will hold the two teams' total weight
            // using the team number as the (integer) key.

            Dictionary<int, int> teamDict = new Dictionary<int, int>();

            teamDict.Add(1, 0); // initialise team 1 total weight
            teamDict.Add(2, 0); // initialise team 2 total weight

            // the first weight encountered will always go into team 1.

            int teamNo = 1;

            // loop through all the weights toggling the team number 
            // dictionary key between 1 and 2.

            foreach(int singlePersonsWeight in allPeopleArray)
            {
                teamDict[teamNo] += singlePersonsWeight;
                teamNo = (teamNo % 2)+1; // toggle team number between 1 and 2
            }

            // return each team's grand total as an integer array.

            return new int[] { teamDict[1], teamDict[2] };
        }
    }
}

