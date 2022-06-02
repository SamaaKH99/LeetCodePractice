public class NumArray {

    private int[] prefixSum;

        public NumArray(int[] nums)
        {
            prefixSum = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                prefixSum[i] = nums[i];
                if (i > 0)
                    prefixSum[i] += prefixSum[i - 1];
            }
        }

        public int SumRange(int i, int j)
        {
            int sum = prefixSum[j];
            if (i > 0)
                sum -= prefixSum[i - 1];
            return sum;
        }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * int param_1 = obj.SumRange(left,right);
 */