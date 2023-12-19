public class DrawerShiftDownDecorator : IDrawer
{
    IDrawer _drawer;
    int _shift;
    public DrawerShiftDownDecorator(IDrawer drawer, int shift)
    {
        _drawer = drawer;
        _shift = shift;

    }
    public void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        _drawer.DrawBorder(numCols, numRows, maxValLength);

    }

    public void DrawCellBorder(int col, int row, int maxValLength)
    {
        _drawer.DrawCellBorder(col, row + _shift, maxValLength);

    }

    public void DrawContent(string cont, int col, int row, int maxValLength)
    {
        _drawer.DrawContent(cont, col, row + _shift, maxValLength);

    }
}