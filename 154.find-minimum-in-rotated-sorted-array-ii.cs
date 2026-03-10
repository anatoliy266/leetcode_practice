/*
 * @lc app=leetcode id=154 lang=csharp
 *
 * [154] Find Minimum in Rotated Sorted Array II
 */

// @lc code=start
public class Solution {
    public int FindMin(int[] nums) {
        var (left, right) = (0, nums.Length-1);
        while (left < right)
        {
            int mid = left + (right - left) /2;
            //както надо определить какая из частей не сортированная, как?
            if (nums[right] < nums[mid])
            {
                left = mid+1;
            }
            else if (nums[right] > nums[mid]) right = mid;
            else right--;
        }

        
        return nums[left];
    }
}
// @lc code=end

