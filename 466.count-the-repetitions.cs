/*
 * @lc app=leetcode id=466 lang=csharp
 *
 * [466] Count The Repetitions
 */

// @lc code=start
public class Solution {
    public int GetMaxRepetitions(string s1, int n1, string s2, int n2) {
        var len1 = s1.Length;
        var len2 = s2.Length;

        var s1CountRecord = new int[len2 + 1];
        var s2CountRecord = new int[len2 + 1];
        var (s1Count, s2Count) = (0, 0);
        var index = 0;

        while (s1Count < n1) {
            s1Count++;
            for (var i = 0; i < len1; i++) {
                if (s1[i] == s2[index]) {
                    index++;
                    if (index == len2) {
                        s2Count++;
                        index = 0;
                    }
                }
            }

            if (s1CountRecord[index] > 0) {
                var prevS1Count = s1CountRecord[index];
                var prevS2Count = s2CountRecord[index];
                
                var s1InCycle = s1Count - prevS1Count;
                var s2InCycle = s2Count - prevS2Count;
                
                var remainingS1 = n1 - s1Count;
                var cycles = remainingS1 / s1InCycle;
                
                s1Count += cycles * s1InCycle;
                s2Count += cycles * s2InCycle;
            } else {
                s1CountRecord[index] = s1Count;
                s2CountRecord[index] = s2Count;
            }
        }
        return s2Count / n2;
    }
}
// @lc code=end

