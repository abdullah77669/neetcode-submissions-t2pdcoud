public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        //List<List<string>> list= new List<List<string>>();
        List<string> word=new List<string>();
       /* if(strs.Length==1)
        {
            word.Add(strs[0]);
            list.Add(word);
        }*/
    Dictionary<string,List<string>> list=new Dictionary<string,List<string>>();

        for(int i=0;i<strs.Length;i++)
        {
            char[] chars=strs[i].ToCharArray();
            Array.Sort(chars);
            string key=new string(chars);
            if(list.ContainsKey(key))
            {
               list[key].Add(strs[i]); 
            }
            else
            {
                list.Add(key,new List<string> {strs[i]});
            }
        }
        return list.Values.ToList();

    }
}
