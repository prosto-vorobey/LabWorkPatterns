public class DrawerWithputBorder : ADrawerMatrix
{
    IDrawerDisplay _drawerDisplay;
    public DrawerWithputBorder(IDrawerDisplay drawerDisplay)
    {
        _drawerDisplay = drawerDisplay;

    }
    public override void DrawBorder(int numCols, int numRows, int maxValLength)
    {

    }
    protected override IDrawerDisplay GetDisplay()
    {
        return _drawerDisplay;

    }

}