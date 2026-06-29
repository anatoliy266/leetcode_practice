/*
 * @lc app=leetcode id=456 lang=csharp
 *
 * [456] 132 Pattern
 */

// @lc code=start
public class Solution
{
    public bool Find132pattern(int[] nums)
    {
        if(nums.Length<3) return false;
        var arr = new int[nums.Length];
        arr[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
        {
            arr[i] = Math.Min(arr[i - 1], nums[i]);
        }

        // for (var j = 0; j < nums.Length; j++)
        // {
        //     var min = arr[j];
        //     for (var k = j + 1; k < nums.Length; k++)
        //     {
        //         if (min < nums[k] && nums[k] < nums[j]) return true;
        //     }

        // }

        // var rightElements = new SortedSet<int>();
        var stack = new Stack<int>();

        for (int j = nums.Length - 1; j >= 0; j--)
        {
            if (nums[j] > arr[j])
            {
                // if (arr[j] + 1 <= nums[j] - 1)
                // {
                //     var subset = rightElements.GetViewBetween(arr[j] + 1, nums[j] - 1);

                //     if (subset.Count > 0)
                //     {
                //         return true;
                //     }
                // }
                while (stack.Count > 0 && stack.Peek() <= arr[j]) stack.Pop();

                if (stack.Count > 0 && stack.Peek() < nums[j]) return true;

            }
            // rightElements.Add(nums[j]);
            stack.Push(nums[j]);
        }

        return false;
    }
}
// @lc code=end

