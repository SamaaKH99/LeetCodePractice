public class Solution {
    public int LengthOfLastWord(string s) {
            //declaration
            int lastWord = 0;
            int current = 0;
            int i;
            //logic
            for(i = 0; i < s.Length; i++)
            {
                current ++;
                if (s[i] == ' ')
                    current = 0;
                else
                    lastWord = current;
            }
            return lastWord;
    }
}