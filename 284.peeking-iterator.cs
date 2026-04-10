/*
 * @lc app=leetcode id=284 lang=csharp
 *
 * [284] Peeking Iterator
 */

// @lc code=start
// C# IEnumerator interface reference:
// https://docs.microsoft.com/en-us/dotnet/api/system.collections.ienumerator?view=netframework-4.8

class PeekingIterator {
    // iterators refers to the first element of the array.
    // IEnumerator<int> _iterator;
    // bool _hasNext = true;
    // int _next;
    private List<int> _nums = new List<int>();
    private int _idx = 0;

    public PeekingIterator(IEnumerator<int> iterator) {
        do {
            _nums.Add(iterator.Current);
        } while (iterator.MoveNext());
        
    }
    
    // Returns the next element in the iteration without advancing the iterator.
    public int Peek() => _nums[_idx];
    
    public int Next() => _nums[_idx++];
    
    // Returns false if the iterator is refering to the end of the array of true otherwise.
    public bool HasNext() => _idx < _nums.Count;
}
// @lc code=end

