public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        // Declaration
        // Let the first row equals to 1
        IList<IList<int>> res = new List<IList<int>>() { new List<int>() { 1 } };
        
        // Logic
        for (int i = 2; i <= numRows; i++)
        {
            List<int> cur = new List<int>() { 1 };
            
            for (int j = 1; j < i - 1; j++)
                cur.Add(res[i - 2][j - 1] + res[i - 2][j]);
            
            cur.Add(1);
            
            res.Add(cur);
        }
        
        return res;
    }
}