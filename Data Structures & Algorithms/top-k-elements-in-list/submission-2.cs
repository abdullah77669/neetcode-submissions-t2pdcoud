public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if(k==0)
        return [];

        Dictionary<int,int> freq=new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
            if(!freq.ContainsKey(nums[i]))
            freq.Add(nums[i],0);

            freq[nums[i]]++;
        }
        int[] result=new int[k];
        for(int j=0;j<k;j++)
        {
            int temp=freq.MaxBy(x=>x.Value).Key;
            result[j]=temp;
            freq.Remove(temp);
        }
        return result;


    }
}
