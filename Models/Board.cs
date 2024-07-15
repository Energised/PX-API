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
}