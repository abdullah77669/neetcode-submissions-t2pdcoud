public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        if(s.Length==0)
            return 0;

        bool[] content=new bool[s.Length];
        int counter=0,result=0;
        Array.Sort(s);

        for(int i=0;i<g.Length;i++)
        {
            counter=0;
            while(counter<s.Length)
            {
                if(s[counter]>=g[i] && content[counter]==false)
                {
                    content[counter]=true;
                    result++;
                    break;
                }
                counter++;
            }
            
        } 
        return result;
        
    }
}