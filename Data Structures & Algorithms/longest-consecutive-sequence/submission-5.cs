public class Solution {
    public int LongestConsecutive(int[] nums) {
       if(nums.Length==0)
       return 0;
        if(nums.Length==1)
        return 1;
        
        HashSet<int> num=new HashSet<int>();
        for(int i=0;i<nums.Length;i++)
        {
            num.Add(nums[i]);
        }
        int result=0;
        foreach(int a in num)
        {
            if(!num.Contains(a-1) )
           { int current=a;
            int length=1;
           

           while(num.Contains(current+1))
           {
            length++;
            current++;
           }
           result=Math.Max(result,length);
           }
        }
        return result;
    }
}
