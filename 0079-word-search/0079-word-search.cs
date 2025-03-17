public class Solution {
    private List<List<int>> directions = new List<List<int>>()
    {
        new List<int>() { 1, 0 },
        new List<int>() { -1, 0 },
        new List<int>() { 0, 1 },
        new List<int>() { 0, -1 },
    };
    int m,n;
    public bool Exist(char[][] board, string word) {
        m = board.Length;
        n = board[0].Length;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(board[i][j]==word[0] && find(i,j,0,word,board))
                    return true;
            }
        }
        return false;
    }

    public bool find(int i,int j,int idx,string word,char[][] board){
        // Base case: If the entire word is matched
        if(idx==word.Length)
            return true;
        // Boundary checks and visited check
        if(i<0 || j<0 || i>=m || j>=n || board[i][j] == '$')
            return false;
        // Check if the current cell matches the expected character    
        if(board[i][j]!=word[idx])
            return false;
        char temp = board[i][j];
        board[i][j]='$';
        // Explore all four directions
        foreach (var dir in directions) {
            int _i = i + dir[0], _j = j + dir[1];
            if (find(_i, _j, idx + 1, word, board))
                return true;
        }
        board[i][j]=temp;
        return false;
    }
}