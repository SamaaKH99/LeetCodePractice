public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //Declaration
            string current = strs[0]; // flower

            // Logic
            for (int i = 1; i < strs.Length; i++)
            {
                string common = "";
                // Case
                if (current.Length == 0)
                    break;

                for (int j = 0; j < strs[i].Length; j++)
                {
                    //char[] tmp = strs[i].ToCharArray();
                    if (j < current.Length && current[j] == strs[i][j])
                    {
                        common += strs[i][j];
                    }
                    else
                        break;
                }
                current = common;
            }

            return current;
    }
}