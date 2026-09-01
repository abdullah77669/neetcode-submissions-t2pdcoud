public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        
        int a=0;
        for(int i=0;i<nums.Length;i++)
    {
        if(nums[i]!=val )
        {
            nums[a]=nums[i];
            a++;
                    
        }
    }
    
    return a;
    }
}