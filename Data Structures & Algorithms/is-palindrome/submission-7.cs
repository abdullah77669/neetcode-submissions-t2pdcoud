public class Solution {
    public bool IsPalindrome(string s) {
        if(s.Length==1)
        return true;
        int left=0,right=s.Length-1;

        while(right>left)
        {
            if(!char.IsLetterOrDigit(s[left]))
            {
                left++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right]))
            {
                right--;
                continue;
            }
            if(char.ToLower(s[left++])!=char.ToLower(s[right--]))
            
                 return false;
            
        }
        return true;
    }
}
