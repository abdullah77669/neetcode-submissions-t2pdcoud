public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        if(nums.Length==1)
        return 1;

        int ascendingResult=1,temp=1;

        for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]>nums[i-1])
            {
                temp++;
                ascendingResult=Math.Max(ascendingResult,temp);
            }

            else
            temp=1;
        }
        temp=1;
        int descResult=1;
    for(int i=1;i<nums.Length;i++)
        {
            if(nums[i]<nums[i-1])
            {
                temp++;
                descResult=Math.Max(descResult,temp);
            }

            else
            temp=1;
    }
    return Math.Max(descResult,ascendingResult);

    }
}