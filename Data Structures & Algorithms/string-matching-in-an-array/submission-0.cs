public class Solution {
    public List<string> StringMatching(string[] words) {
       Array.Sort(words,(a,b)=>a.Length.CompareTo(b.Length));

       List<string> result=new List<string>();
       for(int i=0;i<=words.Length-2;i++)
       {
        string alpha=words[i];

        for(int j=i+1;j<=words.Length-1;j++)
        {
            if(words[j].Contains(words[i]))
            {
                result.Add(words[i]);
                break;
            }
        }
       }
       return result;


    }
}