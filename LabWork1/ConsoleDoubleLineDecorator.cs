﻿public class ConsoleDoubleLineDecorator : IConsolePrimitives
{
    IConsolePrimitives _prm;
    public ConsoleDoubleLineDecorator(IConsolePrimitives prm)
    {
        _prm = prm;
        GetIndex = 1;

    }
    public int GetIndex { get; }
    public void Angle(int corX, int corY)
    {
        _prm.Angle(corX, corY);
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
    public void TextCell(string text, int corX, int corY)
    {
        _prm.TextCell(text, corX, corY);

    }

}
