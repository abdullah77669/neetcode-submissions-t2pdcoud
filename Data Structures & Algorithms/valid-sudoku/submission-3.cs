public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char> checkRow = new HashSet<char>();
        HashSet<char> checkColumn = new HashSet<char>();

        // Check rows and columns
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] != '.')
                {
                    if (checkRow.Contains(board[i][j]))
                        return false;

                    checkRow.Add(board[i][j]);
                }

                if (board[j][i] != '.')
                {
                    if (checkColumn.Contains(board[j][i]))
                        return false;

                    checkColumn.Add(board[j][i]);
                }
            }

            checkRow.Clear();
            checkColumn.Clear();
        }

        // Check 3x3 boxes
        for (int startRow = 0; startRow < 9; startRow += 3)
        {
            for (int startColumn = 0; startColumn < 9; startColumn += 3)
            {
                HashSet<char> box = new HashSet<char>();

                for (int row = startRow; row < startRow + 3; row++)
                {
                    for (int column = startColumn; column < startColumn + 3; column++)
                    {
                        if (board[row][column] == '.')
                            continue;

                        if (box.Contains(board[row][column]))
                            return false;

                        box.Add(board[row][column]);
                    }
                }
            }
        }

        return true;
    }
}