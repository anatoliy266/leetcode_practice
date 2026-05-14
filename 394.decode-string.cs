/*
 * @lc app=leetcode id=394 lang=csharp
 *
 * [394] Decode String
 */

// @lc code=start
public class Solution
{
    public string DecodeString(string s)
    {
        var text = "";
        var num = 0;
        var textStack = new Stack<string>();
        var numStack = new Stack<int>();
        for (var i = 0; i < s.Length; i++)
        {
            if (Char.IsDigit(s[i]))
            {
                num = num * 10 + (s[i] - '0');
            }
            else if (Char.IsLetter(s[i]))
            {
                text += s[i];
            }
            else if (s[i] == '[')
            {
                numStack.Push(num);
                textStack.Push(text);
                num = 0;
                text = "";
            }
            else if (s[i] == ']')
            {
                var d = numStack.Count > 0 ? numStack.Pop() : 1;
                var c = textStack.Count > 0 ? textStack.Pop() : "";
                var sumText = "";
                for (var j = 0; j < d; j++) sumText += text;
                text = c + sumText;
            }
        }
        return text;
    }
}
// @lc code=end

