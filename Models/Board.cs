namespace PX_API.Models;

public class Board
{
    public int Width { get; set; }
    public int Height { get; set; }
    public BlockState[][] BoardState { get; set; }
    
    public int[][] RowHints { get; set; }
    public int[][] ColumnHints { get; set; }

    public BlockState[][] SolvedBoardState { get; set; }
    public BlockState[][] SolvedBoardStateAsColumns { get; set; }

    public int[][] RowHintsWithoutZeroes => RowHints.Select(rh => rh.Where(h => h != 0).ToArray()).ToArray();
    public int[][] ColumnHintsWithoutZeroes => ColumnHints.Select(ch => ch.Where(h => h != 0).ToArray()).ToArray();
}