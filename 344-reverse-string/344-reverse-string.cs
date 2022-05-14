public class Solution {
    public void ReverseString(char[] s) {
            // Declarations
            int start = 0;
            int end = s.Length - 1;

            // Cases
            if (s.Length == 0 || s == null)
                return;            

            // Logic
            while(start < end)
            {
                char tmp = s[start];
                s[start] = s[end];
                s[end] = tmp;
                start++;
                end--;
            }
    }
}