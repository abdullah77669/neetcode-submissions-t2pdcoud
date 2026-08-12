public class Solution {
    public string LargestGoodInteger(string num) {
        string result="";
        for (int i=2;i<num.Length;i++)
        {
            if(num[i]==num[i-1] && num[i]==num[i-2])
            {
                string current=num.Substring(i-2,3);
                if(result=="" || string.Compare(result,current)<0)
                {
                    result=current;
                }
            }
        }
        return result;
    }
}