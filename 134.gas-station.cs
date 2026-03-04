/*
 * @lc app=leetcode id=134 lang=csharp
 *
 * [134] Gas Station
 */

// @lc code=start
public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        //if (gas.Sum() < cost.Sum()) return -1;
        var totalGas = 0;
        var currentGas = 0;
        var start = 0;
        for (var i =0; i < gas.Length; i++)
        {
            totalGas += gas[i] - cost[i];
            currentGas += gas[i] - cost[i];
            if (currentGas < 0) {start = i+1; currentGas = 0;}
        }
        return totalGas >= 0 ? start: -1;
    }
}
// @lc code=end

