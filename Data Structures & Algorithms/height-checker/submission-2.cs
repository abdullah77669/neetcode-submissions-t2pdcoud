public class Solution {
    public int HeightChecker(int[] heights) {

       int[] expected=new int[heights.Length];
       
       Array.Copy(heights,expected,heights.Length);
       int result=0;
      Array.Sort(expected);

      for (int i=0;i<heights.Length;i++)
      {
        if(heights[i]!=expected[i])
        result++;
      }
      return result;


    }
}