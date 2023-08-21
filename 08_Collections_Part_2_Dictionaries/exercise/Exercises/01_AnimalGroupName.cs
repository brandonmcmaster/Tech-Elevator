using System;
using System.Collections.Generic;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         * Given the name of an animal, return the name of a group of that animal
         * (e.g. "Elephant" -> "Herd", "Rhino" - "Crash").
         *
         * The animal name should be case insensitive so "elephant", "Elephant", and
         * "ELEPHANT" should all return "Herd".
         *
         * If the name of the animal is not found, null, or empty, return "unknown".
         *
         * Rhino -> Crash
         * Giraffe -> Tower
         * Elephant -> Herd
         * Lion -> Pride
         * Crow -> Murder
         * Pigeon -> Kit
         * Flamingo -> Pat
         * Deer -> Herd
         * Dog -> Pack
         * Crocodile -> Float
         *
         * AnimalGroupName("giraffe") → "Tower"
         * AnimalGroupName("") -> "unknown"
         * AnimalGroupName("walrus") -> "unknown"
         * AnimalGroupName("Rhino") -> "Crash"
         * AnimalGroupName("rhino") -> "Crash"
         * AnimalGroupName("elephants") -> "unknown"
         *
         */
        public string AnimalGroupName(string animalName)
        {
            Dictionary<string, string> animalNames = new Dictionary<string, string>(StringComparer.CurrentCultureIgnoreCase);
            animalNames["Rhino"] = "Crash";
            animalNames["Giraffe"] = "Tower";
            animalNames["Elephant"] = "Herd";
            animalNames["Lion"] = "Pride";
            animalNames["Crow"] = "Murder";
            animalNames["Pigeon"] = "Kit";
            animalNames["Flamingo"] = "Pat";
            animalNames["Deer"] = "Herd";
            animalNames["Crocodile"] = "Float";

            if (string.IsNullOrEmpty(animalName) || !animalNames.ContainsKey(animalName))
                {
                return "unknown";
            }
            
            return animalNames[animalName];
        }
    }
}
