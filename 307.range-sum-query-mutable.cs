/*
 * @lc app=leetcode id=307 lang=csharp
 *
 * [307] Range Sum Query - Mutable
 */

// @lc code=start
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;



public class NumArray {

    // private int[] _sums;
    // private List<int> _nums;
    // private int blockSize;
    // private int[] ints;
    // private int[] blockSums;

    private int[] binaryTree;   
    private int n;  
    public NumArray(int[] nums) {
        // _nums = new List<int>(nums);
        // _sums = new int[nums.Length+1];
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     _sums[i+1] = _sums[i] + nums[i];
        // }
        
        // ints = nums;
        // blockSize = (int)Math.Max(1, Math.Sqrt(nums.Length));
        // blockSums = new int[nums.Length /  blockSize+1];
        // for (var i = 0; i < nums.Length; i++)
        // {
        //     blockSums[i / blockSize] += nums[i];
        // }
        if (nums.Length == 0) return;
        binaryTree = new int[nums.Length*4];
        n = nums.Length;
        Build(nums, 1, 0, nums.Length-1);
    }

    private void Build(int[] nums, int v, int l, int r)
    {
        if (l == r) binaryTree[v] = nums[l];
        else
        {
            var mid = l + (r-l) /2;

            Build(nums, 2*v, l, mid);
            Build(nums, 2*v +1,  mid+1, r);

            binaryTree[v] = binaryTree[2 * v] + binaryTree[2 * v + 1];
        }
    }

    public void Update(int index, int val) {
        // _nums[index] = val;
        // for (var i = index; i < _nums.Count; i++)
        // {
        //     _sums[i+1] = _sums[i] + _nums[i];
        // }

        // blockSums[index / blockSize] += val - ints[index]; 
        // ints[index] = val;
        UpdateTree(1, 0, n - 1, index, val);
    }

     private void UpdateTree(int v, int l, int r, int idx, int val)
    {
        if (l == r) 
        {
            binaryTree[v] = val;
        }
        else 
        {
            int mid = l + (r - l) / 2;
            if (idx <= mid)
                UpdateTree(2 * v, l, mid, idx, val); 
            else
                UpdateTree(2 * v + 1, mid + 1, r, idx, val); 
            
            binaryTree[v] = binaryTree[2 * v] + binaryTree[2 * v + 1];
        }
        
    }
    
    public int SumRange(int left, int right) {
        // return _sums[right+1] - _sums[left];
        
        // var sum = 0;
        // while (left % blockSize != 0 && left <= right)
        // {
        //     sum += ints[left];
        //     left++;
        // }
        
        // while (left + blockSize - 1 <= right)
        // {
        //     sum += blockSums[left / blockSize];
        //     left += blockSize;
        // }

        // while (left <= right)
        // {
        //     sum += ints[left];
        //     left++;
        // }
        // return sum;
        return GetSum(1, 0, n - 1, left, right);
    }

    private int GetSum(int v, int tl, int tr, int l, int r) {
        if (l > r) 
            return 0;
        if (l == tl && r == tr)
            return binaryTree[v];
        int tm = tl + (tr - tl) / 2;
        int leftPart = GetSum(2 * v, tl, tm, l, Math.Min(r, tm));
        int rightPart = GetSum(2 * v + 1, tm + 1, tr, Math.Max(l, tm + 1), r);
        return leftPart + rightPart;
    }
}

/**
 * Your NumArray object will be instantiated and called as such:
 * NumArray obj = new NumArray(nums);
 * obj.Update(index,val);
 * int param_2 = obj.SumRange(left,right);
 */
// @lc code=end

