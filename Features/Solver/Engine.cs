using PX_API.Models;

namespace PX_API.Features.Solver;

// given an empty board with hints
// we need to do the following:
// - fill based on max hint size (MaxSizeHints)
// - fill based on hints where the outcome only has 1 answer (HintSumCase)
// - fill on the iterative case
//    - place first permutation
//    - count how many spaces are left on the end (spaces_left)
//    - if the number of spaces left is less than any of the hint options (hint_option - spaces_left) > 0
//      - we can keep (hint_option - spaces_left) number of spaces from the first hint block
// we can iterate this case, then check to see if the picross has been solved

public class Engine
{
    public Board BoardData { get; set; }
    
    public DateTime StartTime { get; set; }
    public DateTime FinishTime { get; set; }

    public Engine(Board boardData)
    {
        BoardData = boardData;
    }

    public void Solve()
    {
        // handle definite cases
        ApplyMaxSizeHintCase();
        ApplyHintSumCase();
        //FillRandomSquare();

    }

    private void ApplyMaxSizeHintCase()
    {
        int hintIndex = 0;
        foreach (var rowHint in BoardData.RowHints)
        {
            var rowHintWithoutZeroes = rowHint.Where(h => h != 0).ToArray();
            // if the hint is the same as the length of the row
            if (rowHintWithoutZeroes.Length == 1 && rowHintWithoutZeroes[0] == BoardData.Width)
            {
                // fill all spaces on the row
                for(int r = 0; r < BoardData.Width; r++)
                {
                    BoardData.BoardState[hintIndex][r] = BlockState.Filled;
                }
            }

            hintIndex++;
        }

        hintIndex = 0;
        
        foreach (var columnHint in BoardData.ColumnHints)
        {
            var columnHintWithoutZeroes = columnHint.Where(h => h != 0).ToArray();
            if (columnHintWithoutZeroes.Length == 1 && columnHintWithoutZeroes[0] == BoardData.Height)
            {
                // fill all spaces in the row
                for (int c = 0; c < BoardData.Height; c++)
                {
                    BoardData.BoardState[c][hintIndex] = BlockState.Filled;
                }
            }

            hintIndex++;
        }
    }

    private void ApplyHintSumCase()
    {
        throw new NotImplementedException();
    }

    private void FillRandomSquare()
    {
        BoardData.BoardState[0][0] = BlockState.Filled;
    }

    public bool IsSolved()
    {
        return BoardData.BoardState == BoardData.SolvedBoardState;
    }
}