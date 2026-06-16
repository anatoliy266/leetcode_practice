/*
 * @lc app=leetcode id=438 lang=csharp
 *
 * [438] Find All Anagrams in a String
 */

// @lc code=start
public class Solution
{
    // public IList<int> FindAnagrams(string s, string p)
    // {
    //     var res = new List<int>();
    //     if (s.Length < p.Length) return res;

    //     var quantS = new int[26];
    //     var quantP = new int[26];

    //     for (var i = 0; i < p.Length; i++)
    //     {
    //         quantP[p[i] - 'a']++;
    //         quantS[s[i] - 'a']++;
    //     }

    //     // if (quantS.SequenceEqual(quantP))
    //     if (ArraysEqual(quantS, quantP))
    //     {
    //         res.Add(0);
    //     }

    //     var (l, r) = (0, p.Length);


    //     while (r < s.Length)
    //     {
    //         quantS[s[r] - 'a']++;
    //         quantS[s[l] - 'a']--;

    //         // if (quantS.SequenceEqual(quantP))
    //         if (ArraysEqual(quantS, quantP))
    //         {
    //             res.Add(l + 1);
    //         }

    //         l++;
    //         r++;
    //     }

    //     return res;
    // }

    // private bool ArraysEqual(int[] a, int[] b)
    // {
    //     for (var i = 0; i < 26; i++)
    //     {
    //         if (a[i] != b[i]) return false;
    //     }
    //     return true;
    // }

    public IList<int> FindAnagrams(string s, string p)
    {
        var res = new List<int>();
        if (s.Length < p.Length) return res;

        // Используем один массив для разницы частот символов
        // Положительное число — нужно символов из p
        // Отрицательное число — избыток символов в текущем окне s
        var counts = new int[26];
        foreach (var ch in p)
        {
            counts[ch - 'a']++;
        }

        // Считаем, сколько уникальных символов из p нам нужно найти
        var requiredMatches = 0;
        for (int i = 0; i < 26; i++)
        {
            if (counts[i] > 0) requiredMatches++;
        }

        var l = 0;
        var currentMatches = 0;

        for (var r = 0; r < s.Length; r++)
        {
            // 1. Обрабатываем правый (входящий) символ
            var rChar = s[r] - 'a';
            counts[rChar]--; // Забираем символ из "нужных"

            // Если количество этого символа стало ровно 0, значит частота совпала с p
            if (counts[rChar] == 0)
            {
                currentMatches++;
            }

            // 2. Если окно превысило размер p, сжимаем его слева
            if (r - l + 1 > p.Length)
            {
                var lChar = s[l] - 'a';

                // Если до возврата символа частота была идеальной (0), 
                // то возвращая символ, мы ломаем совпадение
                if (counts[lChar] == 0)
                {
                    currentMatches--;
                }

                counts[lChar]++; // Возвращаем символ обратно в "нужные"
                l++;
            }

            // 3. Если количество совпавших уникальных символов равно требуемому
            if (currentMatches == requiredMatches)
            {
                res.Add(l);
            }
        }

        return res;
    }
}
// @lc code=end

