public class Solution {
    public void SortColors(int[] nums) {
        
        int cRed=0,cWhite=0,cBlue=0;

        for (int i=0;i<nums.Length;i++)
        {
            if(nums[i]==0)
            cRed++;

            else if(nums[i]==1)
            cWhite++;

            else
            cBlue++;
        }
        for(int j=0;j<cRed;j++)
        nums[j]=0;

        for(int k=cRed;k<cRed+cWhite;k++)
        nums[k]=1;

        for(int l=cRed+cWhite;l<cRed+cWhite+cBlue;l++)
        nums[l]=2;
    }
}