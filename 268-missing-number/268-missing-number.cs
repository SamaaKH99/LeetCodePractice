public class Solution {
    public int MissingNumber(int[] nums) {
        // Declarations
            int length = nums.Length;
            int tmp = 0;
            // Special Case
            if (nums.Length == 0 || nums.Length == null)
            {
                return 0;
            }
            // Logic

            int[] sortedArray = nums;
            Array.Sort(sortedArray);
            for (int i = 0; i < length; i++)
            {

                if (sortedArray[i] == tmp)
                {
                    tmp++;
                }
                else
                    break;
                    
            }

            return tmp;
    }
}