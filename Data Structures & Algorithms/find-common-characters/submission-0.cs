public class Solution {
    public IList<string> CommonChars(string[] words) {
        
        List<string> common=new List<string>();

        List<string> fWord=new List<string>();

        int i=0;
        while(i<words[0].Length)
        {
            fWord.Add(words[0][i].ToString());
            i++;
        }
        foreach(string alpha in fWord)
        {
            bool yes=true;
            for (int j=1;j<words.Length;j++)
            {
                int index= words[j].IndexOf(alpha);
                if(!words[j].Contains(alpha))
                {
                    yes=false;
                    Console.WriteLine(alpha);
                    break;
                }
               words[j]=words[j].Remove(index,1);
            }
            if(yes==true)
            common.Add(alpha);
        }
        return common;

    }
}