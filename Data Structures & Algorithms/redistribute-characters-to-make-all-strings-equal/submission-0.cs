public class Solution {
    public bool MakeEqual(string[] words) {
        if(words.Length==1)
        return true;

       Dictionary<char,int> freq=new Dictionary<char,int>();

        for(int i=0;i<words.Length;i++)
        {
            for(int j=0;j<words[i].Length;j++)
            {
                if(!freq.ContainsKey(words[i][j]))
                {
                    freq.Add(words[i][j],0);
                    Console.WriteLine(words[i][j]);
                }
                freq[words[i][j]]++;
            }           

        }

       foreach(var key in freq)
       {
        if(key.Value%words.Length!=0)
        {
            return false;
        }
       }
       return true;

    }
}