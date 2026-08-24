public class Solution {
    public bool hasDuplicate(int[] nums) {
        
        if(nums.Length==0 || nums.Length ==1)
        return false;

        HashSet<int> freq=new HashSet<int>();

        for (int i=0;i<nums.Length;i++)
        {
            if(freq.Contains(nums[i]))
            return true;

            freq.Add(nums[i]);
        }
        return false;
    }
}