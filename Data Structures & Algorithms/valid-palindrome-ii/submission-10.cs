public class Solution {
    public bool ValidPalindrome(string s) {
        int left=0,right=s.Length-1;

        while(left<right)
        {
            if(s[left]!=s[right])
            {
                return Check(s,left+1,right) || Check(s,left,right-1);
            }
            left++;
            right--;
        }
        return true;
    }
    private bool Check(string s,int left,int right)
    {
        while(left<right)
        {
            if(s[left]!=s[right])
            return false;

            left++;
            right--;
        }
        return true;
    }
}