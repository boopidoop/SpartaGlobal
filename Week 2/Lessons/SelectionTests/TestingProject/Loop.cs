namespace Loop
{
    public static class LoopTypes
    {
        public static int HighestForEachLoop(List<int> nums)
        {
            int highestNum = int.MinValue;

            if (nums.Count <= 0)
                return 0;

            foreach (int num in nums)
                if (num > highestNum)
                    highestNum = num;

            return highestNum;
        }

        public static int HighestForLoop(List<int> nums)
        {
            int highestNum = int.MinValue;

            if (nums.Count <= 0)
                return 0;

            for (int i = 0; i < nums.Count; i++)
                if (nums[i] > highestNum)
                    highestNum = nums[i];

            return highestNum;
        }

        public static int HighestWhileLoop(List<int> nums)
        {
            int highestNum = int.MinValue, count = 0;

            if (nums.Count <= 0)
                return 0;

            while (count != nums.Count)
            {
                if (nums[count] > highestNum)
                    highestNum = nums[count];
                count++;
            }

            return highestNum;
        }

        public static int HighestDoWhileLoop(List<int> nums)
        {
            int highestNum = int.MinValue;
            int count = 0;

            if(nums.Count <= 0)
                return highestNum;

            do
            {
                if (nums[count] > highestNum)
                    highestNum = nums[count];
                count++;
            } while (count < nums.Count);

            return highestNum;
        }

        public static int LowestForEachLoop(List<int> nums)
        {
            int lowestNum = int.MaxValue;

            if (nums.Count <= 0)
                return 0;

            foreach (int num in nums)
                if (num < lowestNum)
                    lowestNum = num;

            return lowestNum;
        }

        public static int LowestForLoop(List<int> nums)
        {
            int lowestNum = int.MaxValue;

            if (nums.Count <= 0)
                return 0;

            for (int i = 0; i < nums.Count; i++)
                if (nums[i] < lowestNum)
                    lowestNum = nums[i];

            return lowestNum;
        }

        public static int LowestWhileLoop(List<int> nums)
        {
            int lowestNum = int.MaxValue, count = 0;

            if (nums.Count <= 0)
                return 0;

            while (count != nums.Count)
            {
                if (nums[count] < lowestNum)
                    lowestNum = nums[count];
                count++;
            }

            return lowestNum;
        }

        public static int LowestDoWhileLoop(List<int> nums)
        {
            int lowestNum = int.MaxValue, count = 0;

            if (nums.Count <= 0)
                return 0;

            do
            {
                if (nums[count] < lowestNum)
                    lowestNum = nums[count];
                count++;
            } while (count < nums.Count);

            return lowestNum;
        }
    }
}