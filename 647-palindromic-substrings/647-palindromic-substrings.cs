public class Solution {
    public int CountSubstrings(string s) {
       // Declarations
            int counter = 0;
            int left, right;

            // Logic
            for (int i = 0; i < s.Length; i++)
            {
                left = right = i;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    counter += 1;
                    left--;
                    right++;
                }

                left = i;
                right = i + 1;

                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    counter += 1;
                    left--;
                    right++;
                }
            }
            return counter; 
    }
}