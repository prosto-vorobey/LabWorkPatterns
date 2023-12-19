public class ConsoleDisplay : IDisplay
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
    public void Border (int corX1, int corY1, int corX2, int corY2)
    {
        _primitives.LineHorizontal(corX1 + 1, corY1, corX2 - 1);
        _primitives.LineHorizontal(corX1 + 1, corY2, corX2 - 1);
        _primitives.LineVertical(corX1, corY1 + 1, corY2 - 1);
        _primitives.LineVertical(corX2, corY1 + 1, corY2 - 1);
        _primitives.Angle(corX1, corY1);
        _primitives.Angle(corX1, corY2);
        _primitives.Angle(corX2, corY1);
        _primitives.Angle(corX2, corY2);

    }

}