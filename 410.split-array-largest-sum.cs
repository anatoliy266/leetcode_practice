/*
 * @lc app=leetcode id=410 lang=csharp
 *
 * [410] Split Array Largest Sum
 */

// @lc code=start
public class Solution {
    public int SplitArray(int[] nums, int k) {
        // var (l, r) = (nums.Max(), nums.Sum());
        var l = 0;
        var r = 0;
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > l) l = nums[i];
            r += nums[i];
        }
        while (l < r)
        {
            var mid = l + (r-l) / 2;
            var cnt = 0;
            var sum = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (sum + nums[i] > mid)
                {
                    sum = nums[i];
                    cnt++;
                }
                else
                {
                    sum+= nums[i];
                }
            }
            cnt++;

            if (cnt <= k) r = mid;
            else l = mid+1;
        }
        return l;
    }
}
// @lc code=end

// Дан массив целых чисел nums и целое число k. 
// Необходимо разбить массив nums на k непустых подмассивов таким образом, 
// чтобы минимизировать наибольшую сумму каждого подмассива.

// Вернуть минимизированную наибольшую сумму разбиения.

// Подмассив — это непрерывная часть массива.