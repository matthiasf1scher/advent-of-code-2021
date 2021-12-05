namespace AdventOfCode2021
{
    public class IncreasedCounter
    {
        public int CountWindow(List<int> depthValues, int windowSize)
        {
            int numberOfIncreasingValues = 0;

            for (int i = windowSize; i < depthValues.Count; i++)
            {
                if (depthValues[i - windowSize] < depthValues[i])
                {
                    numberOfIncreasingValues++;
                }
            }

            return numberOfIncreasingValues;
        }
    }
}
