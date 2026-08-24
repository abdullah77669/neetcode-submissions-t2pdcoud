public class Solution {

    public string Encode(IList<string> strs) {
        string result="";
        for(int i=0;i<strs.Count;i++)
        {
            int temp =strs[i].Length;
            result+=temp;
            result+="#";
            result+=strs[i];
        }
        return result;
    }

    public List<string> Decode(string s) {
        List<string> decoded=new List<string>();
        string temp="";
        for(int i=0;i<s.Length;i++)
        {
            temp+=s[i];
            if(s[i+1]=='#')
            {
                int num=int.Parse(temp);
                temp="";
                for(int j=i+2;j<=i+num+1;j++)
                {
                    temp+=s[j];
                }
                decoded.Add(temp);
                temp="";
                i=i+num+1;
            }
        }
        return decoded;
   }
}
