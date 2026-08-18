public class Solution {
    public int[] VowelStrings(string[] words, int[][] queries) {
        bool[] vowels=new bool[words.Length];

        for (int i=0;i<words.Length;i++)
    {
        if(words[i][0]=='a' || words[i][0]=='e' || words[i][0]=='i' ||words[i][0]=='o' ||words[i][0]=='u' )
        {
            int last=words[i].Length-1;
            if(words[i][last]=='a' || words[i][last]=='e' || words[i][last]=='i' ||words[i][last]=='o' ||words[i][last]=='u' )
               vowels[i]=true;
        }
    }
    int length=queries.Length;
    int[] result=new int[length];
    for(int i=0;i<length;i++)
    {
        for(int j=queries[i][0];j<=queries[i][1];j++)
        {
            if(vowels[j]==true)
            result[i]++;
        }
    }
    return result;
    }
}