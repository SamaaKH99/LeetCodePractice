public class Solution {
    public int FindLengthOfLCIS(int[] nums) {
            // Declaration
            int counter = 1;
            int tmp = 1;

            // Special Cases
            if (nums.Length == 0)
                return 0;

            // Logic
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    tmp++;
                    counter = Math.Max(counter, tmp);
                }
                else tmp = 1;
            }
            return counter;
    }
}