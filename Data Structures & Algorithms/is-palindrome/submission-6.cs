public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length==1)
        return true;
        s=new string (s.Where(char.IsLetterOrDigit).ToArray());
        s=s.ToLower();
        int ptr2=s.Length-1,ptr1=0;

        while(ptr1<ptr2)
        {
           if(s[ptr1]!=s[ptr2])
           return false;
           ptr2--;
           ptr1++;

        }
        return true;
    }
}
