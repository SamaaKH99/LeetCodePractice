public class Solution {
    public double Average(int[] salary) {
        // Declarations
            double averageSalary = 0;
            double sum = 0;
            double max = salary.Max();
            double min = salary.Min();
            double counter = salary.Length - 2;

            // Logic
            for(int i = 0; i < salary.Length; i++)
            {
                sum = sum + salary[i];                
            }
            
            sum = sum - (max + min);
            averageSalary = sum / counter;

            return averageSalary;
    }
}