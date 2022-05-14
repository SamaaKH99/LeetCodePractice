public class Solution {
    public int SubtractProductAndSum(int n) {
        // Declaration
            int tmp = 0;
            int sum = 0;
            int product = 1;

            // Special Cases
            if (n == 0)
                return 0;

            // logic
            while(n != 0)
            {
                tmp = n % 10;
                sum += tmp;
                product *= tmp;
                n= n / 10;
            }
            return product - sum;
    }
}