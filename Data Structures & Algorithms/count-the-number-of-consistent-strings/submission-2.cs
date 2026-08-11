public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) {
        bool check=true;
        int ptr=0,count=0;

        for(int i=0;i<words.Length;i++)
        {
            while(ptr<words[i].Length)
            {
                if(!allowed.Contains(words[i][ptr]))
                {
                    check=false;

                    break;

                }
                ptr++;

            }
            if(check==true)
            {
                count++;

            }
            check=true;
            ptr=0;

        }
        return count;
    }
}