public class Solution {
    public int MaxScore(string s) {
        int score=0;
        int n=1;
        int ones=s.Count(s=>s=='1');
        int zeros=s.Count(s=>s=='0');
        if(zeros==s.Length)
        {
            return zeros-1;
        }
        else if(ones==s.Length)
        {
            return ones-1;
        }
        int leftScore=0,rightScore=0;
        if(s[0]=='0')
           {
            leftScore=1;
            rightScore=ones;

           }
           else
           {
            leftScore=0;
            rightScore=ones-1;
           }
           score=rightScore+leftScore;

        for (int i=1;i<s.Length-1;i++)
        {
            int tempScore=0;
           if(s[i]=='0')
           {
            leftScore+=1;
            tempScore=leftScore+rightScore;

           }
           else
           {
            rightScore-=1;
            tempScore=rightScore+leftScore;
           }
           if(tempScore>score)
           {
            score=tempScore;
           }
        }
        return score;
    }
}