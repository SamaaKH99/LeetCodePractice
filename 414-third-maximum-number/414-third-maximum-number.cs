public class Solution {
    public int ThirdMax(int[] nums) {
    // Using LINQ
            int[] numsWithoutDuplication = nums.OrderBy(x => x).Distinct().ToArray();
            // Cases
            if (numsWithoutDuplication.Length == 0)
                return 0;
            else if (numsWithoutDuplication.Length == 1)
                return numsWithoutDuplication[0];
            else if (numsWithoutDuplication.Length == 2)
                return numsWithoutDuplication[1];
            return numsWithoutDuplication[^3];   
    }
}