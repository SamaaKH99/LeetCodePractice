public class Solution {
    public int StrStr(string haystack, string needle) {
        // Case
            if (haystack.Length == 0 || needle.Length == 0)
                return 0;
            if (haystack.Length < needle.Length)
                return -1;
            // Logic
            for(int i = 0; i < (haystack.Length + 1 - needle.Length); i++)
            {
                for(int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else if (j == needle.Length - 1)
                        return i;
                }
            }
            return -1;
    }
}