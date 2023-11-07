public interface IDrawerMatrix
{
    int GetIndex { get; }
    void DrawContent(string cont, int col, int row, int maxValLength);
    void DrawBorder(int numCols, int numRows, int maxValLength);

}
public abstract class ADrawerMatrix : IDrawerMatrix
{
    public int GetIndex { get; protected set; }
    public virtual void DrawContent(string cont, int col, int row, int maxValLength)
    {
        int corCellX = (col + 1) * (maxValLength + 1);
        int corCellY = row + 1;
        GetDisplay().Content(cont, corCellX, corCellY);

    }
    public abstract void DrawBorder(int numCols, int numRows, int maxValLength);
    protected abstract IDrawerDisplay GetDisplay();

}