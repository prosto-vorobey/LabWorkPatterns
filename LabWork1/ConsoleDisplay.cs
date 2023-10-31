public class ConsoleDisplay : IDrawerDisplay
{
    private IConsolePrimitives _primitives;
    public ConsoleDisplay(IConsolePrimitives primitives)
    {
        _primitives = primitives;

    }
    public void Content (string cont, int corCellX, int corCellY)
    {
        _primitives.TextCell(cont, corCellX, corCellY);

    }
    public void Border (int corCellX, int corCellY)
    {
        _primitives.LineHorizontal(1, 0, corCellX - 1);
        _primitives.LineHorizontal(1, corCellY, corCellX - 1);
        _primitives.LineVertical(0, 1, corCellY - 1);
        _primitives.LineVertical(corCellX, 1, corCellY - 1);
        _primitives.Angle(0, 0);
        _primitives.Angle(0, corCellY);
        _primitives.Angle(corCellX, 0);
        _primitives.Angle(corCellX, corCellY);

    }

}