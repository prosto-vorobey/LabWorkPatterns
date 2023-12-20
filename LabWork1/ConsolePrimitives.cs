using System;
using System.Dynamic;

public interface IConsolePrimitives
{
    void TextCell(string text, int corX, int corY);
    void LineHorizontal(int corX1, int corY, int corX2);
    void LineVertical(int corX, int corY1, int corY2);
    void Angle(int corX, int corY);

}
public class ConsolePrimitives : IConsolePrimitives
{
    public void TextCell(string text, int corX, int corY)
    {
        int contLenght = text.Length;
        Console.SetCursorPosition(corX - contLenght, corY);
        Console.WriteLine(text);

    }
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
    public void Angle(int corX, int corY)
    {
        Console.SetCursorPosition(corX, corY);
        Console.WriteLine("+");

    }

}
