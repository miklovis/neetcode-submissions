public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new HashSet<List<int>>(new ListComparer());
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length - 2; i++) {
            for(int j = i+1; j < nums.Length - 1; j++) {
                for(int k = j+1; k < nums.Length; k++) {
                    if(nums[i] + nums[j] + nums[k] == 0) {
                        var newList = new List<int>();
                        newList.Add(nums[i]);
                        newList.Add(nums[j]);
                        newList.Add(nums[k]);
                        result.Add(newList);
                    }
                }
            }
        }

        return result.ToList();
    }
}

public class ListComparer : IEqualityComparer<List<int>>
{
    public bool Equals(List<int> x, List<int> y)
    {
        if (x == null || y == null) return x == y;
        return x.SequenceEqual(y);
    }

    public int GetHashCode(List<int> obj)
    {
        // A simple way to generate a hash based on contents
        int hash = 17;
        foreach (var item in obj)
        {
            hash = hash * 31 + item.GetHashCode();
        }
        return hash;
    }
}
