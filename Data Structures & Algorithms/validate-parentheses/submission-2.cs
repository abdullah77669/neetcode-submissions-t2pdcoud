public class Solution {
    public bool IsValid(string s) {
        
        if(s.Length%2==1)
        return false;

        string temp="";

        for(int i=0;i<s.Length;i++)
        {
            if(s[i]== ')')
            {
                if(temp.Length==0 || temp[temp.Length-1]!='(')
                {
                    return false;
                }
                else
                temp=temp.Remove(temp.Length-1);
            }
            else if(s[i]==']')
            {
                if(temp.Length==0 || temp[temp.Length-1]!='[')
                {
                    return false;
                }
                else
                temp=temp.Remove(temp.Length-1);
            }
            else if(s[i]=='}')
            {
                if(temp.Length==0 || temp[temp.Length-1]!='{')
                {
                    return false;
                }
                else
                temp=temp.Remove(temp.Length-1);
            }
            else
            {
                temp+=s[i];
            }
        }
        if(temp.Length==0)
        return true;

        return false;
    }
}
