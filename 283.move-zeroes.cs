/*
 * @lc app=leetcode id=283 lang=csharp
 *
 * [283] Move Zeroes
 */

// @lc code=start
using Microsoft.VisualBasic;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == 0) 
        // }

        // var (left, right) = (0,nums.Length-1);
        // while (left < right)
        // {
        //     while (left < right && nums[right] == 0) 
        //         right--;
        //     if (nums[left] > nums[right]) (nums[left], nums[right]) = (nums[right], nums[left]);
        //     left++;
        // }

        // var (left, right) = (0, nums.Length - 1);

        // while (left < right)
        // {
        //     if (nums[left] == 0)
        //     {
        //         // Брутфорсим: тянем этот ноль вправо до упора (до границы right)
        //         int current = left;
        //         while (current < right)
        //         {
        //             (nums[current], nums[current + 1]) = (nums[current + 1], nums[current]);
        //             current++;
        //         }
        //         // Уменьшаем правую границу, так как там теперь точно ноль
        //         right--;
        //     }
        //     else
        //     {
        //         // Если под left не ноль, просто идем дальше
        //         left++;
        //     }
        // }

        // var slow = 0;
        // for (var fast = 0; fast < nums.Length; fast++)
        // {
        //     if (nums[fast] != 0)
        //     {
        //         nums[slow] = nums[fast];
        //         slow++;
        //     }
        // }

        // for (var i = slow; i < nums.Length; i++)
        // {
        //     nums[i] = 0;
        // }

        // for slow in range(len) 
        //     if a[slow] == 0: 
        //         a[slow] = a[fast]; 
        //         fast++;
        // for i in range(fast, len) 
        //     a[i] = 0 

        // var result = nums.OrderBy(x => x == 0).ToArray();
        // Array.Copy(result, nums, nums.Length);

        // Array.Sort(nums, (a,b) => (a==0).CompareTo(b==0));

        var (fast, slow) = (0,0);
        while (fast < nums.Length)
        {
            if (nums[fast] != 0)
            {
                (nums[fast], nums[slow]) = (nums[slow], nums[fast]);
                
                slow++;
            }
            fast++;
        }
    }
}


// @lc code=end

