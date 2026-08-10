public class Solution {
    public string KthDistinct(string[] arr, int k) {
        int nth=0;
        for(int i=0;i<arr.Length;i++)
        {
            bool distinct= true;
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[i]==arr[j] && i!=j)
                {
                    distinct=false;
                    break;

                }
            }
            if(distinct==true && nth<k)
            {
                nth++;

            }
            if(k==nth)
            {
                return arr[i];
            }
        }
        return "";
    }
}