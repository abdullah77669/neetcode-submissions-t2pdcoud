public class Solution {
    public string MergeAlternately(string word1, string word2) {
        string output="";
        int a=0;
        if(word1.Length>word2.Length)
        {
            for(int i=0;i<word1.Length;i++)
            {
                
                if(a==word2.Length)
                {
                    while(i<word1.Length)
                    {
                       output+=word1[i];
                       i++;
                    }
                    break;
                }
                output+=word1[i];
                output+=word2[a];
                a++;
            }
        }
        else
        {
            for(int j=0;j<word2.Length;j++)
            {
                
                if(a==word1.Length)
                {
                    while(j<word2.Length)
                    {
                       output+=word2[j];
                       j++;
                    }
                    break;
                }
                output+=word1[j];
                output+=word2[a];
                a++;
            }
        }
        return output;
    }

}