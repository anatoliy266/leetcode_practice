/*
 * @lc app=leetcode id=420 lang=csharp
 *
 * [420] Strong Password Checker
 */

// @lc code=start
public class Solution
{
    public int StrongPasswordChecker(string password)
    {
        var missingSymbols = 0;
        var arr = new bool[3];
        for (var i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i])) arr[0] = true;
            if (char.IsUpper(password[i])) arr[1] = true;
            if (char.IsLower(password[i])) arr[2] = true;
        }
        for (var i = 0; i < arr.Length; i++)
        {
            if (!arr[i]) missingSymbols++;
        }

        if (password.Length > 20)
        {
            var deletions = password.Length - 20;
            var leftDeletions = deletions;

            var totalExchange = 0;
            var cheap = 0;
            var expencive = 0;
            var currSeq = 1;
            for (var i = 1; i < password.Length; i++)
            {
                if (password[i] == password[i - 1])
                {
                    currSeq++;
                }
                else
                {
                    if (currSeq >= 3)
                    {
                        totalExchange += currSeq / 3;
                        var discount = currSeq % 3;
                        if (discount == 0) cheap += 1;
                        else if (discount == 1) expencive += 1;
                    }
                    currSeq = 1;
                }
            }
            if (currSeq >= 3)
            {
                totalExchange += currSeq / 3;
                var discount = currSeq % 3;
                if (discount == 0) cheap += 1;
                else if (discount == 1) expencive += 1;
            }

            if (cheap > leftDeletions)
            {
                totalExchange -= leftDeletions;
                leftDeletions = 0;
            }
            else
            {
                totalExchange -= cheap;
                leftDeletions -= cheap;
                if (expencive * 2 > leftDeletions)
                {
                    totalExchange -= leftDeletions / 2;
                    leftDeletions = 0;
                }
                else
                {
                    leftDeletions -= expencive * 2;
                    totalExchange -= expencive;
                }
            }
            totalExchange -= leftDeletions / 3;
            return deletions + Math.Max(Math.Max(0, totalExchange), missingSymbols);
        }
        if (password.Length >= 6 && password.Length <= 20)
        {
            var totalExchange = 0;
            var currSeq = 1;
            for (var i = 1; i < password.Length; i++)
            {
                if (password[i] == password[i - 1]) currSeq++;
                else
                {
                    if (currSeq >= 3) totalExchange += currSeq / 3;
                    currSeq = 1;
                }
            }
            if (currSeq >= 3) totalExchange += currSeq / 3;

            return Math.Max(totalExchange, missingSymbols);
        }
        if (password.Length < 6)
        {
            var additions = 6 - password.Length;
            return Math.Max(additions, missingSymbols);
        }
        return 0;
    }
}
// @lc code=end

