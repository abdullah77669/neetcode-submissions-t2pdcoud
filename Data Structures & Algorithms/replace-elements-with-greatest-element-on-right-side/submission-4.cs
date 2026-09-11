public class Solution {
    public int[] ReplaceElements(int[] arr) {
        
        for(int i=0;i<arr.Length-1;i++)
        {
            int x=i+1;
            int max=arr[x];
            while(x<arr.Length)
            {
                max=Math.Max(max,arr[x]);

                x++;
            }
            arr[i]=max;
        }
        arr[arr.Length-1]=-1;
        return arr;
    }
}