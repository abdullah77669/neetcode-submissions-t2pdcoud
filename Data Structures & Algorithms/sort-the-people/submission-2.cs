public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        
        if(heights.Length==1)
        {
            string[] r={names[0]};
            return r;
        }

        Dictionary<int,string> sorted=new Dictionary<int,string>();
        for(int i=0;i<names.Length;i++)
        {
            sorted.Add(heights[i],names[i]);
        }
        string[] result=new string[names.Length];
        int j=0;
        while(sorted.Count!=0)
        {
            int largest=sorted.Keys.Max();
            result[j]=sorted[largest];
            sorted.Remove(largest);
            j++;
        }
        return result;
    }
}