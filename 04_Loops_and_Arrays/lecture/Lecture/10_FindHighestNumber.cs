namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        10. What code do we need to write so that we can find the highest
             number in the array randomNumbers?
             TOPIC: Looping Through Arrays
        */
        public int FindTheHighestNumber(int[] randomNumbers)
        {
            int highest = int.MinValue;

            for (int i = 0; i < randomNumbers.Length; i++ )
                {
                if (highest < randomNumbers[i]) 
                {
                    highest = randomNumbers[i];
                }
            }
            return highest;
        }
    }
}
