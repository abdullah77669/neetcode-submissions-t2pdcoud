public class Solution {
    public int CountSeniors(string[] details) {
      if(details.Length==0)
      {
        return 0;
      }
      int seniors=0;
      for(int i=0;i<details.Length;i++)
      {
        int ten=details[i][11]-'0';
        int ones=details[i][12]-'0';

        int age=ten*10+ones;
        if(age>60)
        {
            seniors++;
        }

      }  
      return seniors;
    }
}