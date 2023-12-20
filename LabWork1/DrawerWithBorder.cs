public class DrawerWithBorder : ADrawer
{
    IDisplay _display;
    public DrawerWithBorder(IDisplay display)
    {
        _display = display;

    }
    public override void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        int width = numCols * (maxValLength + 1);
        int height = numRows * 2;
        _display = GetDisplay();
        Border(0, 0, width, height);

    }
    public override void DrawCellBorder(int col, int row, int maxValLength)
    {
        int corX1 = col * (maxValLength + 1);
        int corX2 = (col + 1) * (maxValLength + 1);
        int corY1 = row * 2;
        int corY2 = (row + 1) * 2;
        _display = GetDisplay();
        Border(corX1, corY1, corX2, corY2);

    }
    protected override IDisplay GetDisplay()
    {
        return _display;

    }

}
