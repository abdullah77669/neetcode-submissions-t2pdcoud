public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        int product=1;
        int zeroCount=0;
        for(int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            {
                zeroCount++;
                if(zeroCount==1)
                continue;
                else if(zeroCount>1)
                break;
            }

            product*=nums[i];
        }
        int[] result=new int[nums.Length];
        if(zeroCount>1)
        {
            return result;
        }
        if(zeroCount==1)
        {
            for(int k=0;k<result.Length;k++)
            {
                if(nums[k]==0)
                result[k]=product;
                else
                result[k]=0;
            }
            return result;
        }
        for(int j=0;j<result.Length;j++)
        {
            

            result[j]=product/nums[j];
        }
        return result;
    }
}
