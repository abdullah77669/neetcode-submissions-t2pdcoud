public class Solution {
    public int Search(int[] nums, int target) {
        
        

        for(int i=0;i<nums.Length;i++)
        {
            if(target<nums[i])
            {
                return -1;
            }
            else if(target==nums[i])
            return i;

        }
        return -1;
    }
}
