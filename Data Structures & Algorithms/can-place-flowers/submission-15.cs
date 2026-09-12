public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        if(n==0)
        return true;
        if(flowerbed.Length==1 && flowerbed[0]==0 && n==1)
        return true;
        if(n==flowerbed.Length)
        return false;

        
        for(int i=0;i<flowerbed.Length;i++)
        {
            if(flowerbed[i]==0)
            {
                bool left=(i==0 || flowerbed[i-1]==0);
                bool right=(i==flowerbed.Length-1 || flowerbed[i+1]==0);
                if(left && right)
                {flowerbed[i]=1;
                    
                n--;

                if(n==0)
                return true;
                }   
                
               
            }
        }
        return false;
    }
}