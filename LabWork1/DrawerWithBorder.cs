public class DrawerWithBorder : ADrawerMatrix
{
    IDrawerDisplay _drawerDisplay;
    public DrawerWithBorder(IDrawerDisplay drawerDisplay)
    {
        _drawerDisplay = drawerDisplay;
        GetIndex = 1;

    }
    public override void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        int width = numCols * (maxValLength + 1);
        int height = numRows * 2;
        _drawerDisplay.Border(0, 0, width, height);

    }
    public override void DrawCellBorder(int col, int row, int maxValLength)
    {
        int corX1 = col * (maxValLength + 1);
        int corX2 = (col + 1) * (maxValLength + 1);
        int corY1 = row * 2;
        int corY2 = (row + 1) * 2;
        GetDisplay().Border(corX1, corY1, corX2, corY2);

    }
    protected override IDrawerDisplay GetDisplay()
    {
        return _drawerDisplay;

    }

}
