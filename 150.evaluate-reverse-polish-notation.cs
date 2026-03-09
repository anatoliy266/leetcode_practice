/*
 * @lc app=leetcode id=150 lang=csharp
 *
 * [150] Evaluate Reverse Polish Notation
 */

// @lc code=start
public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        if (tokens.Length == 1 && !"+-*/".Contains(tokens[0]))
        {
            int.TryParse(tokens[0], out int res);
            return res;
        }
        var stack = new Stack<int>();

        for (var i = 0; i < tokens.Length; i++)
        {
            var c = tokens[i];
            if (int.TryParse(c, out int number))
            {
                stack.Push(number);
            }
            else if ("+-*/".Contains(c))
            {
                var r = stack.Pop();
                var l = stack.Pop();
                int result = c switch
                {
                    "+" => l + r,
                    "-" => l - r,
                    "*" => l * r,
                    "/" => r != 0 ? l / r : 0,
                    _ => throw new ArgumentException(),// default случай
                };

                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}
// @lc code=end

