/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input Array Is Sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var (left, right) = (0, numbers.Length-1);
        while (left < right)
        {
            var sum = numbers[left]+numbers[right];
            if (sum == target)
            {
                break;
            } else if (sum > target) right--;
            else left++;
        }

        return new int[2]{left+1, right+1};
    }
}
// @lc code=end

