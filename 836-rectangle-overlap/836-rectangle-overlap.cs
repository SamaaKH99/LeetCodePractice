public class Solution {
    public bool IsRectangleOverlap(int[] rec1, int[] rec2) {
    // rec1 [x1, y1, x2, y2]
    // rec2 [x1, y1, x2, y2]
    // rec  [0,  1,  2,  3 ]
        // Straight line or a dot
        if (rec1[0] == rec1 [2] || rec1[1] == rec1[3])
            return false;
        else if (rec2[0] == rec2[2] || rec2[1] == rec2[3])
            return false;
        else if(rec1[2] <= rec2[0])
            return false;
        else if (rec1[3] <= rec2[1])
            return false;
        else if (rec1[0] >= rec2[2])
            return false;
        else if (rec1[1] >= rec2[3])
            return false;
        else 
            return true;
    }
}