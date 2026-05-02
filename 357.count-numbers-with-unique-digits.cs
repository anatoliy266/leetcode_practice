/*
 * @lc app=leetcode id=357 lang=csharp
 *
 * [357] Count Numbers with Unique Digits
 */

// @lc code=start
public class Solution
{
    public int CountNumbersWithUniqueDigits(int n)
    {
        if (n == 0) return 1;
        int res = 10;
        int currentStepChoices = 9;
        int available = 9;

        while (n > 1 && available > 0)
        {
            currentStepChoices *= available; // Считаем только новые числа (9*9, потом 81*8...)
            res += currentStepChoices;       // Плюсуем их к общему итогу
            available--;
            n--;
        }
        return res;
    }
}
// @lc code=end

