/*
 * @lc app=leetcode id=207 lang=csharp
 *
 * [207] Course Schedule
 */

// @lc code=start
using System.Runtime.ConstrainedExecution;

public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        // var requestedCourses = new HashSet<int>(); //a
        // var requiredCourses = new HashSet<int>(); //b
        // Array.Sort(prerequisites, (a, b) => a[0].CompareTo(b[0]));
        // for (var i = 0; i < prerequisites.Length; i++)
        // {
        //     if (requestedCourses.Contains(prerequisites[i][1]) 
        //         || requiredCourses.Contains(prerequisites[i][0]))
        //     {
        //         return false;
        //     }
        //     else
        //     {
        //         requestedCourses.Add(prerequisites[i][0]);
        //         requiredCourses.Add(prerequisites[i][1]);
        //     }
        // }
        // return true;

        // var coursesRef = new List<int>[numCourses];
        // for (var i =0; i < numCourses; i++) coursesRef[i] =new List<int>();
        // foreach (var p in prerequisites) coursesRef[p[0]].Add(p[1]);

        // var seen = new int[numCourses];

        // for (var i = 0; i < numCourses; i++)
        // {
        //     if (!DFS(i, coursesRef, seen))
        //     {
        //         return false;
        //     }
        // }
        // return true;

        // Как это ловит алгоритм (Indegree):
        // Ты создаешь массив indegree размером numCourses.
        // Проходишь по всем парам [course, prereq].
        // Делаешь indegree[course]++.
        // Потом смотришь: есть ли хоть один i, где indegree[i] == 0?
        // Есть? Кладешь его в очередь и начинаешь «разматывать» граф.
        // Нет? Значит, все курсы зависят друг от друга по кругу. Сразу return false.
        // Триггер: Если ты не можешь найти «начало» (узел с нулевым количеством входящих стрелок), значит, ты в ловушке цикла.
        var queue = new Queue<int>();
        var indegree = new int[numCourses];
        var coursesRef = new List<int>[numCourses];
        for (var i =0; i < numCourses; i++) coursesRef[i] =new List<int>();
        
        foreach (var p in prerequisites) {
            coursesRef[p[1]].Add(p[0]);
            indegree[p[0]]++;
        }

        for (int i = 0; i < numCourses; i++) 
        {
            if (indegree[i] == 0) queue.Enqueue(i);
        }

        var cnt = 0;
        while (queue.Count > 0)
        {
            cnt++;
            var course = queue.Dequeue();
            foreach (var n in coursesRef[course])
            {
                indegree[n]--;
                if (indegree[n] == 0) queue.Enqueue(n);
            }

            
        }
        return cnt == numCourses;
        

    }

    // public bool DFS(int i, List<int>[] coursesRef, int[] seen)
    // {
    //     if (seen[i] == 1) return false;
    //     if (seen[i] == 2) return true;

    //     seen[i] = 1;
    //     foreach (var n in coursesRef[i])
    //     {
    //         if (!DFS(n, coursesRef, seen)) return false;
    //     }
    //     seen[i] = 2;
    //     return true;
    // }
}
// @lc code=end

