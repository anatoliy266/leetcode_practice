/*
 * @lc app=leetcode id=278 lang=csharp
 *
 * [278] First Bad Version
 */

// @lc code=start
/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        var (left, right) = (1, n);
        while (left < right)
        {
            var mid = left +(right-left)/2;
            if (IsBadVersion(mid)) right = mid;
            else left = mid+1;
        }
        return left;
    }
}
// @lc code=end

