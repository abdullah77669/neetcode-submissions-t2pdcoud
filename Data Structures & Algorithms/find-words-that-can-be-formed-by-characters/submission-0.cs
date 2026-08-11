public class Solution {
    public int CountCharacters(string[] words, string chars) {
        
        int length=0;
        
        Dictionary<char,int> freq1=new Dictionary<char,int>();
        Dictionary<char,int> freq2=new Dictionary<char,int>();
        bool form=true;
        
        for(int i=0;i<chars.Length;i++)
        {
            if(freq1.ContainsKey(chars[i]))
            {
                freq1[chars[i]]++;
            }
            else
            {
                freq1.Add(chars[i],1);
            }
        }

        for(int j=0;j<words.Length;j++)
        {
            for(int k=0;k<words[j].Length;k++)
            {
                if(freq2.ContainsKey(words[j][k]))
                {
                    freq2[words[j][k]]++;

                }
                else 
                {
                    freq2.Add(words[j][k],1);
                }
            }
            foreach(char key in freq2.Keys)
            {
                if(!freq1.ContainsKey(key) || freq2[key]>freq1[key])
                {
                    form= false;
                    break;
                    
                }
               
            }
             if(form==true)
            {
                length+=words[j].Length;
            }
            form=true;
            
            freq2.Clear();
            

        }

        return length;





    }
}