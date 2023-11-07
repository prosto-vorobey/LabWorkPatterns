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
        int height = numRows + 1;
        _drawerDisplay.Border(width, height);

    }
    protected override IDrawerDisplay GetDisplay()
    {
        return _drawerDisplay;

    }

}
