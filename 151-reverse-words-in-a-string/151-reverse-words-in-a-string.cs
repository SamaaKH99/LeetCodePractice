public class Solution {
    public string ReverseWords(string s) {
            
        // Declaration
            StringBuilder x = new();
            string[] str = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int start = 0, end = str.Length-1;
            string tmp = string.Empty;
            
        // Case
            if (s == null)
                return null;
            
        // Logic  
            while(start < end)
            {
                tmp = str[start];
                str[start] = str[end];
                str[end] = tmp;
                start++;
                end--;
            }
            
            for(int i = 0; i < str.Length; i++)
            {
                x.Append(str[i]);
                if(i != str.Length-1)
                    x.Append(' ');
            }
            s = x.ToString();
            return s;
    }
}