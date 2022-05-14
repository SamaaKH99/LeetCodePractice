public class Solution {
    public int ThirdMax(int[] nums) {
        // Using LINQ to remove duplication
            int[] numsWithoutDuplication = nums.Distinct().ToArray();
            Array.Sort(numsWithoutDuplication);

            // Cases
            if(numsWithoutDuplication.Length == 0)
                return 0;
            else if (numsWithoutDuplication.Length == 1)
                return numsWithoutDuplication[0];
            else if (numsWithoutDuplication.Length == 2)
                return numsWithoutDuplication[1];

            // Declarations
            int firstMax = numsWithoutDuplication[numsWithoutDuplication.Length - 1];
            int secondMax = numsWithoutDuplication[numsWithoutDuplication.Length - 2];
            int thirdMax = numsWithoutDuplication[numsWithoutDuplication.Length - 3];

            return thirdMax;   
    }
}