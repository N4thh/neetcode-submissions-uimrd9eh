public class Twitter {
    private Dictionary<int, List<(int tweetId, int time)>> tweet = new Dictionary<int, List<(int tweetId, int time)>>();
    private Dictionary<int, HashSet<int>> fl = new Dictionary<int, HashSet<int>>();
    private int time = 0;
    public Twitter() {
        tweet = new Dictionary<int, List<(int tweetId, int time)>>();
        fl = new Dictionary<int, HashSet<int>>();
    }
    
    public void PostTweet(int userId, int tweetId) {
        if(!tweet.ContainsKey(userId)) {
            tweet[userId] = new List<(int, int)>(); 
        }
        tweet[userId].Add((tweetId, time++)); 
    }
    
    public List<int> GetNewsFeed(int userId) {
        List<int> res = new List<int>();
        PriorityQueue<int, int> list = new PriorityQueue<int, int>();

        if (!fl.ContainsKey(userId)) {
            fl[userId] = new HashSet<int>();
        }
        fl[userId].Add(userId);

        foreach(var fler in fl[userId]) {
            if(tweet.ContainsKey(fler)) {
                for(int i = 0; i < tweet[fler].Count; i++) {
                    var (tid, t) = tweet[fler][i];
                    list.Enqueue(tid, t);
                    if(list.Count > 10) list.Dequeue();
                }
            }
        }

        while(list.Count > 0) {
            res.Add(list.Dequeue());
        }
        res.Reverse();

        return res;
    }
    
    public void Follow(int followerId, int followeeId) {
        if(!fl.ContainsKey(followerId)) { 
            fl[followerId] = new HashSet<int>();
        }
        fl[followerId].Add(followeeId);
    }
    
    public void Unfollow(int followerId, int followeeId) {
        if (followerId == followeeId) return; 

        if(fl.ContainsKey(followerId)) { 
            fl[followerId].Remove(followeeId);
        }
    }
}
