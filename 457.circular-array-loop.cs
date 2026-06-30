/*
 * @lc app=leetcode id=457 lang=csharp
 *
 * [457] Circular Array Loop
 */

// @lc code=start
public class Solution
{
    public bool CircularArrayLoop(int[] nums)
    {
        int GetNext(int i)
        {
            var next = (i + nums[i]) % nums.Length;
            return next >= 0 ? next : next + nums.Length;
        }

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0) continue;
            var (slow, fast) = (i, i);
            while (nums[slow] * nums[GetNext(slow)] > 0 
                && nums[fast] * nums[GetNext(fast)] > 0 
                && nums[fast] * nums[GetNext(GetNext(fast))] > 0)
            {
                slow = GetNext(slow);
                fast = GetNext(GetNext(fast));

                if (slow == fast)
                {
                    if (slow == GetNext(slow)) break;
                    return true;
                }
            }

            slow = i;
            while (nums[slow] * nums[GetNext(slow)] > 0)
            {
                nums[slow] = 0;
                slow = GetNext(slow);
            }
        }
        return false;
    }
}
// @lc code=end

