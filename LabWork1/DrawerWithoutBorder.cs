public class DrawerWithoutBorder : ADrawerMatrix
{
    IDrawerDisplay _drawerDisplay;
    public DrawerWithoutBorder(IDrawerDisplay drawerDisplay)
    {
        _drawerDisplay = drawerDisplay;
        GetIndex = 0;

    }
    public override void DrawBorder(int numCols, int numRows, int maxValLength)
    {

    }
    public override void DrawCellBorder(int col, int row, int maxValLength)
    {

    }
    protected override IDrawerDisplay GetDisplay()
    {
        return _drawerDisplay;

    }

}