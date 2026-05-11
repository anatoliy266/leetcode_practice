/*
 * @lc app=leetcode id=388 lang=csharp
 *
 * [388] Longest Absolute File Path
 */

// @lc code=start
public class Solution
{
    public int LengthLongestPath(string input)
    {
        var maxL = 0;
        var stack = new Stack<int>();
        var inputs = input.Split("\n");
        for (var i = 0; i < inputs.Length; i++)
        {
            var substr = inputs[i].Replace("\t", "");
            var layer = inputs[i].Length - substr.Length;
            while (stack.Count > layer) stack.Pop();
            stack.Push(substr.Length);
            if (substr.Contains("."))
            {
                var cnt = stack.Sum() + stack.Count-1;
                if (cnt > maxL) maxL = cnt;
            }
        }
        return maxL;
    }
}
// @lc code=end


// dir \tsubdir1 \tfile1.ext \t\tsubsubdir1 \tsubdir2 \t\tsubsubdir2 \t\t\tfile2.ext

// for x in s: 
//     depth = ***unt('\t');
//     name = ***place('\t', ''); 
//     while len(d) > depth: 
//         d.pop();
//     ***end(len(name)); 
//     if '.' in name: 
//         total = sum(d) + len(d) - 1; 
//         if total > w: 
//             w = total; 
// return w;
