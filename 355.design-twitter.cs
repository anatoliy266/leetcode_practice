/*
 * @lc app=leetcode id=355 lang=csharp
 *
 * [355] Design Twitter
 */

// @lc code=start
public class Twitter
{
    // SortedList<int, (int userId, int feedId)> feeds = new SortedList<int, (int userId, int feedId)>();
    Dictionary<int, List<(int, int)>> feeds = new Dictionary<int, List<(int, int)>>();
    Dictionary<int, HashSet<int>> followers = new Dictionary<int, HashSet<int>>();
    int timer = 0;
    public Twitter()
    {

    }

    public void PostTweet(int userId, int tweetId)
    {

        // feeds.Add(timer++, (userId, tweetId));
        if (feeds.TryGetValue(userId, out var list)) list.Add((tweetId, timer));
        else feeds[userId] = new List<(int, int)> { (tweetId, timer) };
        timer++;
    }

    public IList<int> GetNewsFeed(int userId)
    {

        var users = followers.GetValueOrDefault(userId, new HashSet<int>());
        users.Add(userId);
        var queue = new PriorityQueue<int, int>();

        foreach (var user in users)
        {
            var fs = feeds.GetValueOrDefault(user, new List<(int, int)>());
            foreach (var f in fs)
            {
                queue.Enqueue(f.Item1, f.Item2);
                if (queue.Count > 10) queue.Dequeue();
            }

        }

        var res = new List<int>();
        while (queue.Count > 0) res.Add(queue.Dequeue());
        res.Reverse();
        return res;

        // var res = feeds.Where(x => (users.Count > 0 && users.Contains(x.Value.userId)) || userId == x.Value.userId)
        //     .Reverse()
        //     .Take(10)
        //     .Select(x => x.Value.feedId)
        //     .ToList();
        // return res;
    }

    public void Follow(int followerId, int followeeId)
    {
        if (followers.TryGetValue(followerId, out var list)) list.Add(followeeId);
        else followers[followerId] = new HashSet<int> { followeeId };
    }

    public void Unfollow(int followerId, int followeeId)
    {
        if (followers.TryGetValue(followerId, out var list))
        {
            list.Remove(followeeId);
            if (list.Count == 0) followers.Remove(followerId);
        }
    }
}

/**
 * Your Twitter object will be instantiated and called as such:
 * Twitter obj = new Twitter();
 * obj.PostTweet(userId,tweetId);
 * IList<int> param_2 = obj.GetNewsFeed(userId);
 * obj.Follow(followerId,followeeId);
 * obj.Unfollow(followerId,followeeId);
 */
// @lc code=end

