public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] answer=new int[2];
        int len= nums.Length;
      for(int a=0;a<len;a++)
      {
        for(int b=0;b<len;b++)
        {
            if(a==b)
            {
                continue;
            }
            if(nums[a]+nums[b]==target)
            {
                if(a<b)
                {
                    answer[0]=a;
                    answer[1]=b;
                }
                else
                {
                    answer[0]=b;
                    answer[1]=a;
                }
                return answer;
            }
        }
      }
      return answer;
    }
}
