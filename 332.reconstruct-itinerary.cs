/*
 * @lc app=leetcode id=332 lang=csharp
 *
 * [332] Reconstruct Itinerary
 */

// @lc code=start
public class Solution {
    public IList<string> FindItinerary(IList<IList<string>> tickets) {
        // var res = new List<IList<string>>();
        // var sortedTickets = tickets.OrderBy(t => t[0]).ThenBy(t => t[1]).ToList();
        // var used = new bool[tickets.Count]; 
        // var dict = new Dictionary<string, (int start, int count)>();

        // for (var i =0; i < sortedTickets.Count; i++)
        // {
        //     if (dict.ContainsKey(sortedTickets[i][0])) 
        //     dict[sortedTickets[i][0]] = (dict[sortedTickets[i][0]].start, dict[sortedTickets[i][0]].count +1);
        //     else dict[sortedTickets[i][0]] = (i, 1);
        // }


        // Backtrack(sortedTickets, new List<string>{"JFK"}, used, dict, res);

        // if (res.Count == 0) return new List<string>();
        // return res[0];
        // var sortedTickets = tickets.OrderBy(t => t[0]).ThenBy(t => t[1]).ToList();
        var dict = new Dictionary<string, PriorityQueue<string, string>>();
        for (var i =0; i < tickets.Count; i++)
        {
            if (!dict.ContainsKey(tickets[i][0])) dict[tickets[i][0]] = new PriorityQueue<string, string>();
            dict[tickets[i][0]].Enqueue(tickets[i][1],tickets[i][1]);
        }
        var res = new LinkedList<string>();
        var stack = new Stack<string>();
        stack.Push("JFK");

        while (stack.Count > 0)
        {
            if (dict.ContainsKey(stack.Peek()) && dict[stack.Peek()].Count > 0) stack.Push(dict[stack.Peek()].Dequeue());
            else res.AddFirst(stack.Pop());
        }
        
        return res.ToList();
    }

    // public bool Backtrack(IList<IList<string>> tickets, List<string> travel, bool[] used, Dictionary<string, (int i, int k)> dict, IList<IList<string>> res)
    // {
    //     if (travel.Count == tickets.Count + 1) {res.Add(new List<string>(travel)); return true;}
    //     var lastTicket = travel.Last();

    //     if (!dict.ContainsKey(lastTicket)) return false;
    //     var (c, k) = dict[lastTicket];
    //     string lastTried = null;
    //     for (var i = c; i < c+k; i++)
    //     {
    //         if (!used[i] && tickets[i][0] == lastTicket && tickets[i][1] != lastTried)
    //         {
                
    //             lastTried = tickets[i][1];

    //             travel.Add(tickets[i][1]);
    //             used[i] = true;
    //             if (Backtrack(tickets, travel, used, dict, res)) return true;
    //             travel.RemoveAt(travel.Count-1);
    //             used[i] = false; 
    //         }
            
    //     }
    //     return false;
    // }
}
// @lc code=end

