public class Solution {
    public int MajorityElement(int[] nums) {
        if(nums.Length==1)
        return nums[0];
        Dictionary<int,int> freq=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
            if(!freq.ContainsKey(nums[i]))
            freq.Add(nums[i],0);

            freq[nums[i]]++;

            if(freq[nums[i]]>(nums.Length/2))
            return nums[i];
        }
        return 0;

    }
}