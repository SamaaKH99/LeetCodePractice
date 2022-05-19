public class Solution {
    public void MoveZeroes(int[] nums) {
        // Declarations
            int tmp;
            // Case
            if(nums.Length == 0)
                return;

            // Logic
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                    continue;
                for(int j = i+1; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                        continue;
                    else
                    {
                        tmp = nums[j];
                        nums[j] = nums[i];
                        nums[i] = tmp;
                        break;
                    }
                }
            }
    }
}