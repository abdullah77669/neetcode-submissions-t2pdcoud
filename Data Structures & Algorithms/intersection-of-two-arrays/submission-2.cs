public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        List<int> result=new List<int>();
        Dictionary<int,int> nums1Freq=new Dictionary<int,int>();
        Dictionary<int,int> nums2Freq=new Dictionary<int,int>();

        for (int i=0;i<nums1.Length;i++)
        {
            if(!nums1Freq.ContainsKey(nums1[i]))
            {
                nums1Freq.Add(nums1[i],0);
            }
            nums1Freq[nums1[i]]++;
        }
        for (int j=0;j<nums2.Length;j++)
        {
            if(!nums2Freq.ContainsKey(nums2[j]))
            {
                nums2Freq.Add(nums2[j],0);
            }
            nums2Freq[nums2[j]]++;
        }
        foreach(var pair in nums1Freq)
        {
            if(nums2Freq.ContainsKey(pair.Key))
            result.Add(pair.Key);
        }
        return result.ToArray();

    }
}