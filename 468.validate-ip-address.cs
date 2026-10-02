/*
 * @lc app=leetcode id=468 lang=csharp
 *
 * [468] Validate IP Address
 */

// @lc code=start
public class Solution
{
    public string ValidIPAddress(string queryIP)
    {
        // if (queryIP.Contains(".") && !queryIP.Contains(":"))
        // {
        //     var parts = queryIP.Split(".");
        //     if (parts.Length != 4) return "Neither";
        //     foreach (var part in parts)
        //     {
        //         if (part.Length == 0 || part.Length > 3) return "Neither";
        //         foreach (var c in part)
        //         {
        //             if (!char.IsDigit(c))
        //             {
        //                 return "Neither";
        //             }
        //         }

        //         if (part.Length > 1 && part.StartsWith("0"))
        //         {
        //             return "Neither";
        //         }
        //         if (!int.TryParse(part, out var intpart))
        //         {
        //             return "Neither";
        //         }
        //         if (intpart > 255 || intpart < 0)
        //         {
        //             return "Neither";
        //         }
        //     }
        //     return "IPv4";
        // }
        // else if (!queryIP.Contains(".") && queryIP.Contains(":"))
        // {
        //     var parts = queryIP.Split(":");
        //     if (parts.Length != 8) return "Neither";
        //     foreach (var part in parts)
        //     {
        //         if (part.Length == 0 || part.Length > 4) return "Neither";
        //         foreach (var c in part)
        //         {
        //             if (!((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')))
        //             {
        //                 return "Neither";
        //             }
        //         }
        //     }
        //     return "IPv6";
        // }
        // else
        // {
        //     return "Neither";
        // }
        var currLen = 0;
        var grpCnt = 0;
        var ip4val = 0;
        var is4 = false;
        var is6 = false;
        foreach (var c in queryIP)
        {
            if (c == '.')
            {
                if (is6) return "Neither";
                is4 = true;
                if (currLen > 3 || currLen < 1) return "Neither";
                grpCnt++;
                currLen = 0;
                ip4val = 0;
            }
            else if (c == ':')
            {
                if (is4) return "Neither";
                is6 = true;
                if (currLen > 4 || currLen < 1) return "Neither";
                grpCnt++;
                currLen = 0;

            }
            else
            {
                currLen++;
                if (is4 || (!is4 && !is6))
                {
                    if (c >= '0' && c <= '9')
                    {
                        if (currLen > 1 && ip4val == 0) return "Neither";
                        ip4val = ip4val * 10 + (c - '0');
                        if (is4)
                        {
                            if (ip4val > 255 || currLen > 3) return "Neither";
                        }
                        else
                        {
                            if (ip4val > 255 || currLen > 3)
                            {
                                is6 = true;
                                if (currLen > 4) return "Neither";
                            }
                        }
                    }
                    else if (is4) return "Neither";
                    else
                    {
                        if ((c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')) is6 = true;
                        else return "Neither";
                    }
                }
                else if (is6)
                {
                    if (!((c >= '0' && c <= '9') || (c >= 'a' && c <= 'f') || (c >= 'A' && c <= 'F')) || currLen > 4)
                    {
                        return "Neither";
                    }
                }
            }
        }
        grpCnt++;

        if (is4)
        {
            if (currLen > 3 || currLen < 1 || grpCnt != 4) return "Neither";
            return "IPv4";
        }
        else if (is6)
        {
            if (currLen > 4 || currLen < 1 || grpCnt != 8) return "Neither";
            return "IPv6";
        }

        return "Neither";
    }
}
// @lc code=end

