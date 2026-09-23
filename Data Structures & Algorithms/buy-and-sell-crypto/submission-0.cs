public class Solution {
    public int MaxProfit(int[] prices) {
        
        int result=0;

        for(int i=0;i<prices.Length-1;i++)
        {
            for(int j=i+1;j<prices.Length;j++)
            {
                int temp=prices[j]-prices[i];
                if(temp>result )
                result=temp;

            }
        }
        return result;
    }
}
