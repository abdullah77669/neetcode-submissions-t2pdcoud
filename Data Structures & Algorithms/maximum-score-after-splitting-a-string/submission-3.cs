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
        for (int i=0;i<s.Length-1;i++)
        {
            int len=s.Length-n;
            string a=s.Substring(0,n);
            string b=s.Substring(i+1,len);

            int tempScore= a.Count(a=>a=='0') + b.Count(b=>b=='1');

            if(tempScore>score)
            score=tempScore;
            Console.WriteLine(score);
            Console.WriteLine(b);

            tempScore=0;
            n++;

        }
        return score;
    }
}