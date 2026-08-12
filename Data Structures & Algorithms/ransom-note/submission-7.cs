public class Solution {
    public bool CanConstruct(string ransomNote, string magazine) {
        Dictionary<char,int> mag=new Dictionary<char,int>();

        for(int c=0;c<magazine.Length;c++)
        {
          if(mag.ContainsKey(magazine[c]))
          {
            mag[magazine[c]]++;
          }
          else
          {
            mag.Add(magazine[c],1);
          }
        }
        int i=0;

        while(i<ransomNote.Length)
        {
          if(mag.ContainsKey(ransomNote[i]) && mag[ransomNote[i]]>=1)
          {
            mag[ransomNote[i]]--;
            i++;
          }
          else //if(mag[ransomNote[i]]==0 || !mag.ContainsKey(ransomNote[i]))
          {
            return false;
          }

        }
        return true;
    }
}