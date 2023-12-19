public class DrawerWithoutBorder : ADrawer
{
    IDisplay _drawerDisplay;
    public DrawerWithoutBorder(IDisplay drawerDisplay)
    {
        _drawerDisplay = drawerDisplay;

    }
    public override void DrawBorder(int numCols, int numRows, int maxValLength)
    {

    }
    public override void DrawCellBorder(int col, int row, int maxValLength)
    {

    }
    protected override IDisplay GetDisplay()
    {
        return _drawerDisplay;

    }

}