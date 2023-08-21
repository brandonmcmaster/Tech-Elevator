﻿using System.Runtime.InteropServices.WindowsRuntime;

namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade 
        {
            get
            {
                double percentage = (double)EarnedMarks / PossibleMarks;
                if (percentage >= .90)
                {
                    return "A";
                }
                else if (percentage >= .80)
                {
                    return "B";
                }
                else if (percentage >= .70)
                {
                    return "C";
                }
                else if (percentage >= .60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }
            }
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }


        
    }
}
