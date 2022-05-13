public class Solution {
    public IList<string> FizzBuzz(int n) {
        // Declarations
            var Answers = new List<string>();
        // Logic
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Answers.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Answers.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Answers.Add("Buzz");
                }
                else
                {
                    Answers.Add(i.ToString());
                }
            }
            return Answers;
    }
}
