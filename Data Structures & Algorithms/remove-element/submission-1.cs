public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int[] result=new int[nums.Length];
        int out1=0,a=0;
        for(int i=0;i<nums.Length;i++)
    {
        if(nums[i]!=val )
        {
            nums[a]=nums[i];
            a++;
                    
        }
    
        
        }
    int c=nums.Length-a;
    return a;
    }
}