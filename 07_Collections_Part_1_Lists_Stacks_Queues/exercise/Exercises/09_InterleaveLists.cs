using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
        Given two lists of Integers, interleave them beginning with the first element in the first list followed
        by the first element of the second. Continue interleaving the elements until all elements have been interwoven.
        Return the new list. If the lists are of unequal lengths, simply attach the remaining elements of the longer
        list to the new list before returning it.
        DIFFICULTY: HARD
        InterleaveLists( [1, 2, 3], [4, 5, 6] )  ->  [1, 4, 2, 5, 3, 6]
        */
        public List<int> InterleaveLists(List<int> listOne, List<int> listTwo)
        {
            List<int> interleavedList = new List<int>();
            int indexOne = 0;
            int indexTwo = 0;

            while (indexOne < listOne.Count || indexTwo < listTwo.Count)
            {
                if (indexOne < listOne.Count)
                {
                    interleavedList.Add(listOne[indexOne]);
                    indexOne++;
                }
                if (indexTwo < listTwo.Count)
                {
                    interleavedList.Add(listTwo[indexTwo]);
                    indexTwo++;
                }
                
            }

            return interleavedList;
 
        }
    }
}
