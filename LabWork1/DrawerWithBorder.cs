public class DrawerWithBorder : ADrawerMatrix
{
    IDrawerDisplay _drawerDisplay;
    public DrawerWithBorder(IDrawerDisplay drawerDisplay)
    {
        _drawerDisplay = drawerDisplay;

    }
    public override void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        int width = numCols * maxValLength;
        int height = numRows * maxValLength;
        _drawerDisplay.Border(width, height);

    }
    protected override IDrawerDisplay GetDisplay()
    {
        return _drawerDisplay;

    }

}
