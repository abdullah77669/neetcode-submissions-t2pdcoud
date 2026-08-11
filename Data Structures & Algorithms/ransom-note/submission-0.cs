public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
    
    int i=0,mSize=magazine.Length,rSize=ransomNote.Length;
    bool[] check=new bool[rSize];
    bool[] check2=new bool[mSize];
      while(i<rSize)
      {
        for(int j=0;j<mSize;j++)
        {
            if(ransomNote[i]==magazine[j] && check2[j]==false)
            {
                check[i]=true;
                check2[j]=true;
                break;
            }

        }
        i++;
      }
      for(int m=0;m<rSize;m++)
      {
        if(check[m]==false)
        return false;
      }

      return true;  
    }
}