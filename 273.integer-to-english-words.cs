/*
 * @lc app=leetcode id=273 lang=csharp
 *
 * [273] Integer to English Words
 */

// @lc code=start
using System.Data.SqlTypes;
using System.Text;

public class Solution {
    public string NumberToWords(int num) {

        
        
        // var list = new List<int>();
        // var res = new List<string>();
        
        // // Твой цикл: разбираем число на цифры
        // while (num > 0)
        // {
        //     list.Insert(0, num % 10); // Вставляем в начало, чтобы индекс 0 был первой цифрой
        //     num /= 10;
        // }
        
        // for (var i = 0; i < list.Count; i++)
        // {
        //     int power = list.Count - 1 - i; // Текущий разряд (0-единицы, 1-десятки, 2-сотни...)
        //     int digit = list[i];

        //     if (digit == 0 && (power % 3 != 0 || (i > 0 && list[i-1] == 0 && (i < 2 || list[i-2] == 0)))) continue;

        //     // Обработка 10-19 (твои elevens)
        //     if (power % 3 == 1 && digit == 1)
        //     {
        //         res.Add(elevens[list[i+1]]);
    
        //         // ПРОВЕРКА РАЗРЯДА ЗДЕСЬ:
        //         // Если "десятка" является частью тысяч или миллионов, добавляем их сразу
        //         if (power == 4 || power == 1) { // 10k или 10 (единицы) - тут ничего не делаем
        //         }
                
        //         // Если мы на позиции 1, 4, 7, то i+1 — это позиция 0, 3, 6 (разряды)
        //         int nextPower = power - 1;
        //         if (nextPower == 3 || nextPower == 6 || nextPower == 9)
        //         {
        //             res.Add(orders[nextPower]);
        //         }

        //         i++; // Пропускаем вторую цифру (ноль в 10)
        //         continue;
        //     }
        //     else if (digit != 0)
        //     {
        //         if (power % 3 == 0) res.Add(digits[digit]);
        //         if (power % 3 == 1) res.Add(tens[digit]);
        //         if (power % 3 == 2) res.Add(digits[digit] + " Hundred");
        //     }

        //     // Добавляем Thousand/Million, если мы в нужной позиции и группа не пустая
        //     if (power == 3 || power == 6 || power == 9)
        //     {
        //         // Проверка, что вся тройка разрядов не нулевая
        //         if (digit != 0 || (i > 0 && list[i-1] != 0) || (i > 1 && list[i-2] != 0))
        //             res.Add(orders[power]);
        //     }
        // }
        
        // return string.Join(" ", res).Trim().Replace("  ", " ");


        if (num == 0) return "Zero";
        var orders = new string[]{"", "Thousand", "Million", "Billion"};
        var res = "";
        var i = 0;
        while (num > 0)
        {
            
            var tail = num % 1000;
            if (tail != 0)
            {
                res = ConvertTriade(tail) + orders[i] + " "+ res;
            }
            num = num/1000;
            i++;
        }
        return res.Trim();
    }

    public string ConvertTriade(int num)
    {
        var digits = new string[]{"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"};
        var elevens = new string[]{"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        var tens = new string[]{"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};

        if (num == 0) return "";
        else if (num < 10) return digits[num] + " ";
        else if (num < 20) return elevens[num-10] + " ";
        else if (num < 100) return tens[num / 10] + " " + ConvertTriade(num % 10);
        else return digits[num / 100] + " Hundred " + ConvertTriade(num % 100);
    }


}
// @lc code=end

