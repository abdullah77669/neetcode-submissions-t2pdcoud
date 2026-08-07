public class Solution {
    public bool IsAnagram(string s, string t) {

        if(s.Length!=t.Length )
        {
            return false;
        }
        else if(s.Length==0)
        {
            return true;
        }

        int lenS=s.Length;
        int lenT=t.Length;
        bool[] visited= new bool[s.Length];

        for(int a=0;a<lenS;a++)
        {
            for(int b=0;b<lenT;b++)
            {
                if(visited[b]==true)
                {
                    continue;
                }
                else if(s[a]==t[b])
                {
                    visited[b]=true;
                    break;
                }
            }

        }

        for(int c=0;c<lenS;c++)
        {
            if(visited[c]==false)
            {
                return false;
            }
        }

        return true;

    }
}
