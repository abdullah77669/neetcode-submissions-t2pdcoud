public class Solution {
    public int RomanToInt(string s) {
        
        Dictionary<char,int> roman=new Dictionary<char,int>{
            {'M',1000},
            {'D',500},
            {'C',100},
            {'L',50},
            {'X',10},
            {'V',5},
            {'I',1}
        };
        int result=0;
        for(int i=0;i<s.Length;i++)
        {
            int temp=roman[s[i]];
            if(s[i]=='X' && s.Length>i+1 && s[i+1]=='L')
            {
                temp=40;
                i++;
            }
            else if(s[i]=='X' && s.Length>i+1 && s[i+1]=='C')
           { 
            temp=90;
            i++;
           }
           else if(s[i]=='C' && s.Length>i+1 && s[i+1]=='D')
           {
            temp=400;
            i++;
           }
            else if(s[i]=='C' && s.Length>i+1 && s[i+1]=='M')
           {
            temp=900;
            i++;
           }
           else if(s[i]=='I' && s.Length>i+1 && s[i+1]=='V')
           {
            temp=4;
            i++;
           }
           else if(s[i]=='I' && s.Length>i+1 && s[i+1]=='X')
           {
            temp=9;
            i++;
           }
           result+=temp; 
            
        }
        return result;
    }
}