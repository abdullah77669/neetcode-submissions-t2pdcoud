public class Solution {
    public bool IsPathCrossing(string path) {
        
        if(path.Length==1)
        return false;
        int x=0,y=0;
        HashSet<(int,int)> locations=new HashSet<(int,int)>();
        locations.Add((x,y));

        for(int i=0;i<path.Length;i++)
        {
            if(path[i]=='N')
            {
                y++;
            }
            else if(path[i]=='S')
            {
                y--;
            }
            else if(path[i]=='E')
            {
                x++;
            }
            else
            {
                x--;
            }
            if(locations.Contains((x,y)))
            {
                return true;
            }
            else
            {
                locations.Add((x,y));
            }
        }
        return false;
    }
}