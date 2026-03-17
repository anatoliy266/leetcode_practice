/*
 * @lc app=leetcode id=189 lang=csharp
 *
 * [189] Rotate Array
 */

// @lc code=start
public class Solution {
    public void Rotate(int[] nums, int k) {
        if (k > nums.Length) k %= nums.Length;
        // var cnt = 0;
        // for (var i =0; i < nums.Length; i++)
        // {
        //     if (cnt >= nums.Length) break;
        //     var curr = i;
        //     var prev = nums[i];
        //     do
        //     {
        //         var j = (curr+k) % nums.Length;
        //         var temp = nums[j];
        //         nums[j] = prev;
        //         prev = temp;
        //         curr = j;
        //         cnt++;
        //     }
        //     while (curr != i);
        // }

        var (start, end) = (0, nums.Length-1);
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }

        (start, end) = (0, k-1);
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }

        (start, end) = (k, nums.Length-1);
        while (start < end)
        {
            (nums[start], nums[end]) = (nums[end], nums[start]);
            start++;
            end--;
        }

    }
}
// @lc code=end

