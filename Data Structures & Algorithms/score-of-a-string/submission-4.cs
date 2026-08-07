public class Solution {
    public int ScoreOfString(string s) {

        if(s.Length==0 || s.Length==1)
        {
            return 0;
        }
       
        int score=0,y=0,z=1;

        while(z<s.Length)
        {
            int ascii1=s[z];
            int ascii2=s[y];
            int sum=ascii1-ascii2;
            score+= Math.Abs(sum);
            z++;
            y++;
        }

        return score;
    }
}