public class DecoratorDoubleLine : IPrimitiveLine
{
    IPrimitiveLine _prm;
    public DecoratorDoubleLine (IPrimitiveLine prm)
    {
        _prm = prm;

    }
    public void LineHorizontal(int corX1, int corY, int corX2)
    {
        _prm.LineHorizontal(corX1, corY, corX2);
        _prm.LineHorizontal(corX1, corY + 1, corX2);

    }
    public void LineVertical(int corX, int corY1, int corY2)
    {
        _prm.LineVertical(corX, corY1, corY2);
        _prm.LineVertical(corX + 1, corY1, corY2);

    }

}
