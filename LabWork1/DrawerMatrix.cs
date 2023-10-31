public interface IDrawerMatrix
{
    void DrawContent(string cont, int col, int row, int maxValLength);
    void DrawBorder(int numCols, int numRows, int maxValLength);

}
public abstract class DrawerMatrix : IDrawerMatrix
{
    IDrawerDisplay _drawerDisplay;
    public DrawerMatrix (IDrawerDisplay drawerDisplay)
    {
        _drawerDisplay = drawerDisplay;

    }
    public virtual void DrawContent(string cont, int col, int row, int maxValLength)
    {
        int corCellX = col * maxValLength;
        int corCellY = row * maxValLength;
        _drawerDisplay.Content(cont, corCellX, corCellY);

    }
    public void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        int width = numCols * maxValLength;
        int height = numRows * maxValLength;
        _drawerDisplay.Border(width, height);

    }

}