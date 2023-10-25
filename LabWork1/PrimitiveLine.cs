using System;
using System.Drawing;

public interface IPrimitiveLine
{
    void LineHorizontal(int corX1, int corY, int corX2);
    void LineVertical(int corX, int corY1, int corY2);

}
public class PrimitiveLineScheme1 : IPrimitiveLine
{
    public void LineHorizontal(int corX1, int corY, int corX2)
    {
        for (int i = corX1, j = corY; i <= corX2; i++)
        {
            Console.SetCursorPosition(i, j);
            Console.WriteLine("-");

        }

    }
    public void LineVertical(int corX, int corY1, int corY2)
    {
        for (int i = corX, j = corY1; j <= corY2; j++)
        {
            Console.SetCursorPosition(i, j);
            Console.WriteLine("|");

        }

    }

}
public class PrimitiveLineScheme2 : IPrimitiveLine
{
    private Graphics _graphics;
    private Pen _pen;
    int _penSize = 3;
    public PrimitiveLineScheme2(Graphics graphics)
    {
        _graphics = graphics;
        _pen = new Pen (Color.Black, _penSize);

    }
    public void LineHorizontal(int corX1, int corY, int corX2)
    {
        Point point1 = new Point(corX1 + _penSize, corY + _penSize);
        Point point2 = new Point(corX2 + _penSize, corY + _penSize);
        _graphics.DrawLine(_pen, point1, point2);

    }
    public void LineVertical(int corX, int corY1, int corY2)
    {
        Point point1 = new Point(corX + _penSize, corY1 + _penSize);
        Point point2 = new Point(corX + _penSize, corY2 + _penSize);
        _graphics.DrawLine(_pen, point1, point2);

    }

}
