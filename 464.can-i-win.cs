/*
 * @lc app=leetcode id=464 lang=csharp
 *
 * [464] Can I Win
 */

// @lc code=start
public class Solution {
    public bool CanIWin(int maxChoosableInteger, int desiredTotal) {
        if (desiredTotal <= maxChoosableInteger) return true;
        var sum = (1 + maxChoosableInteger) * maxChoosableInteger / 2;
        if (sum < desiredTotal) return false;
        
        var memo = new Dictionary<int, bool>();
        return Dfs(maxChoosableInteger, desiredTotal, 0, memo);
    }

    private bool Dfs(int maxChoosableInteger, int desiredTotal, int usedMask, Dictionary<int, bool> memo) {
        if (memo.ContainsKey(usedMask)) return memo[usedMask];
        
        for (var i = 1; i <= maxChoosableInteger; i++) {
            var mask = 1 << (i - 1);
            
            if ((usedMask & mask) == 0) {
                if (desiredTotal <= i || !Dfs(maxChoosableInteger, desiredTotal - i, usedMask | mask, memo)) {
                    memo[usedMask] = true;
                    return true;
                }
            }
        }
        
        memo[usedMask] = false;
        return false;
    }
}
// @lc code=end

