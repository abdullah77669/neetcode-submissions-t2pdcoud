
public class Solution {
    public List<List<int>> Generate(int numRows) {
        List<List<int>> result = new List<List<int>>();
        
        for(int i = 1; i <= numRows; i++)
        {
            List<int> temp = new List<int>();

            if(i == 1)
            {
                temp.Add(1);
                result.Add(temp);
                continue;
            }

            List<int> last = result[result.Count - 1];

            int[] newArray = new int[last.Count + 2];

            for(int k = 0; k < last.Count; k++)
                newArray[k + 1] = last[k];

            int ptr1 = 0, ptr2 = 1;

            for(int j = 1; j <= last.Count + 1; j++)
            {
                temp.Add(newArray[ptr1] + newArray[ptr2]);
                ptr1++;
                ptr2++;
            }

            result.Add(temp);
        }

        return result;
    }
}
