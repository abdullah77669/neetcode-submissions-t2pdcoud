public class Solution {
    public string LargestGoodInteger(string num) {
          
          string result=string.Empty,zeroString=string.Empty;
          int sum=0;
          for(int i=num.Length-1;i>1;i--)
    {
        int temp1=num[i]-'0',temp2=num[i-1]-'0',temp3=num[i-2]-'0';
       
       if(temp1==0 && temp2==0 && temp3==0)
       zeroString= "000";
       else if(num[i]==num[i-1] && num[i]==num[i-2])
        {
            int tempSum=temp1+(temp2*10)+(temp3*100);
            if(sum<tempSum)
            {
                sum=tempSum;
                Console.WriteLine(sum);
            }

            tempSum=0;
        }
        
    }
    if(zeroString!=String.Empty && sum==0)
    {
        return zeroString;
    }
    else if(zeroString=="" && sum==0)
    {
        return "";
    }
    result=sum.ToString();
        return result;
    }
}