public class Solution {
    public int MaxArea(int[] heights) {
        int left=0,right=heights.Length-1;
        int height=0,width=0,result=0;

        while(left<right)
        {
            height=Math.Min(heights[left],heights[right]);
            width=right-left;
            result=Math.Max(result,width*height);
            if(heights[left]>heights[right])
            right--;
            else
            left++;
        }
        return result;
    }
}
