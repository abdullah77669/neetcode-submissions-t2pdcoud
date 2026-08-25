public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix=new int[nums.Length];
        int[] suffix=new int[nums.Length];

        prefix[0]=1;
        suffix[nums.Length-1]=1;
        for(int i=1;i<prefix.Length;i++)
        prefix[i]=nums[i-1]*prefix[i-1];

        for(int j=suffix.Length-2;j>=0;j--)
        suffix[j]=suffix[j+1]*nums[j+1];

        int[] result=new int[nums.Length];

        for(int k=0;k<result.Length;k++)
        {
            result[k]=prefix[k]*suffix[k];
        }
        return result;
    }
}
