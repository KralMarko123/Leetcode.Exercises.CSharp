
namespace LeetcodeExercises.Easy
{
    public static class NumberOfStepsToReduceToZero
    {
        public static int NumberOfSteps(int num)
        {
            var numberOfSteps = 0;

            while (num != 0)
            {
                if (num % 2 == 0) num /= 2;
                else num--;

                numberOfSteps++;
            }

            return numberOfSteps;
        }
    }
}