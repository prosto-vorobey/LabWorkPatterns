public interface IDrawerMatrix
{
    void DrawContent(string cont, int col, int row, int maxValLength);
    void DrawBorder(int numCols, int numRows, int maxValLength);

}
public abstract class ADrawerMatrix : IDrawerMatrix
{
    public virtual void DrawContent(string cont, int col, int row, int maxValLength)
    {
        int corCellX = col * maxValLength;
        int corCellY = row * maxValLength;
        GetDisplay().Content(cont, corCellX, corCellY);

    }
    public abstract void DrawBorder(int numCols, int numRows, int maxValLength);
    protected abstract IDrawerDisplay GetDisplay();

}