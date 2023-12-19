public interface IDrawer
{
    void DrawContent(string cont, int col, int row, int maxValLength);
    void DrawCellBorder(int col, int row, int maxValLength);
    void DrawBorder(int numCols, int numRows, int maxValLength);

}
public abstract class ADrawer : IDrawer
{
    private IDisplay _display;
    public void DrawContent(string cont, int col, int row, int maxValLength)
    {
        int corCellX;
        corCellX = (col + 1) * (maxValLength + 1);
        int corCellY = row * 2 + 1;
        _display = GetDisplay();
        Content(cont, corCellX, corCellY);

    }
    abstract public void DrawCellBorder(int col, int row, int maxValLength);
    abstract public void DrawBorder(int numCols, int numRows, int maxValLength);
    protected void Content(string cont, int corCellX, int corCellY)
    {
        _display.Content(cont, corCellX, corCellY);

    }
    protected void Border(int corX1, int corY1, int corX2, int corY2)
    {
        _display.Border(corX1, corY1, corX2, corY2);

    }
    protected abstract IDisplay GetDisplay();

}