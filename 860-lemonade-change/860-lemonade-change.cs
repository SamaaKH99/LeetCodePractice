public class Solution {
    public bool LemonadeChange(int[] bills) {
        //Declaration
            int fiveBill = 0;
            int tenBill = 0;
            
            //Logic
            for (int i = 0; i < bills.Length; i++)
            {
                if(bills[i] == 5)
                {
                    fiveBill++;
                }
                else if(bills[i] == 10)
                {
                    if (fiveBill <= 0)
                        return false;
                    fiveBill -= 1;
                    tenBill++;                    
                }
                else if(bills[i] == 20)
                {
                    // - 3 x5 OR -10 -5
                    if(tenBill >= 1 && fiveBill >= 1)
                    {
                        tenBill -= 1;
                        fiveBill -= 1; 
                    }
                    else if(tenBill <= 0 && fiveBill >= 3)
                    {
                        fiveBill -= 3;
                    }
                    else
                        return false;
                } 
            }
            return true;
    }
}