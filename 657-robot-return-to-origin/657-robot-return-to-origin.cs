public class Solution {
    public bool JudgeCircle(string moves) {
        // Declaration
            int up = 0;
            int down = 0;
            int left = 0;
            int right = 0;
            int i = 0;
            int Length = moves.Length;
            
            // Case
            if(moves.Length == 0)
                return false;

            // Logic
            while (i != Length)
            {
                if (moves[i] == 'U')
                    up += 1;
                else if (moves[i] == 'D')
                    down += 1;
                else if (moves[i] == 'L')
                    left += 1;
                else if (moves[i] == 'R')
                    right += 1;
                i++;
            }
            if(left != right || down != up)
                return false;
            return true;
        
    }
}