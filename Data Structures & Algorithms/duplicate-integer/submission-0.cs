public class Solution {
    public bool hasDuplicate(int[] nums) {
        int len= nums.Length;

        for (int x=0;x<len;x++)
        {
            int a=0;
            while(a<len)
            {
                if(a==x)
                {
                    break;
                }
                else if(nums[x]==nums[a])
                {
                    return true;
                }
                else 
                a++;
            }
        }
        return false;
    }
}