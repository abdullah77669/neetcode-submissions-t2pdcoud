public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        
        int sum=0,left=0,right=numbers.Length-1;
        int[] r=new int[2];
        while(left<right)
        {
            sum=numbers[left]+numbers[right];
            if(sum>target)
            right--;
            else if(sum<target)
            left++;
            else if(sum==target)
            {
                r[0]=left+1;
                r[1]=right+1;
                break;
            }
            sum=0;
        }
        
        return r;
    }
}
