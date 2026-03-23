/*
 * @lc app=leetcode id=210 lang=csharp
 *
 * [210] Course Schedule II
 */

// @lc code=start
public class Solution {
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var order = new List<int>();
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
            order.Add(course);
            foreach (var n in coursesRef[course])
            {
                indegree[n]--;
                if (indegree[n] == 0) queue.Enqueue(n);
            }
        }
        if (cnt != numCourses) return [];
        else return order.ToArray();
    }
}
// @lc code=end

