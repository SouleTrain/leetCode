public class Solution {
    public int[] FindErrorNums(int[] nums) {
        int[] newList = new int[2];
        HashSet<int> seen = new HashSet<int>();
        foreach(int i in nums)
        {
            if (!seen.Add(i))
            {
                newList[0] = i;
            }
        }
        for(int i = 1; i <= nums.Length; i++)
        {
            if(!seen.Contains(i))
            {
                newList[1] = i;
            }
        }
        return newList;
    }
}