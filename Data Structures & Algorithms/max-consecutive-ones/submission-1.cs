public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int temp=0,result=0;

        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==1)
            {
                temp++;
                result=Math.Max(result,temp);
            }

            else
            {
                result=Math.Max(temp,result);
                temp=0;
            }
        }
        return result;
    }
}