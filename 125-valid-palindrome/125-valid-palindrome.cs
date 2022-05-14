public class Solution {
    public bool IsPalindrome(string s) {
        // Using String Builder to remove Punctuation
            var myStringBuilder = new StringBuilder();
            foreach (char c in s)
            {
                if (!char.IsPunctuation(c))
                    myStringBuilder.Append(c);
            }
            s = myStringBuilder.ToString().ToLower();
            s = s.Replace(" ", "");
            s = s.Replace("`", "");

            // Declarations
            int start = 0;
            int end = s.Length - 1;

            // Cases
            if (s.Length == 0 || s.Length == 1)
                return true;

            // Logic
            while (start < end)
            {
                if (s[start] != s[end])
                    return false;
                start++;
                end--;

            }
            return true;
    }
}