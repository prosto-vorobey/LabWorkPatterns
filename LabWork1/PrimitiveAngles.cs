using System;

public interface IPrimitiveAngles
{
    void Angles(int corX1, int corX2, int corY1, int corY2);

}

public class PrimitiveAngles : IPrimitiveAngles
{
    public void Angles(int corX1, int corX2, int corY1, int corY2)
    {
        AngleCreate(corX1, corY1);
        AngleCreate(corX2, corY1);
        AngleCreate(corX1, corY2);
        AngleCreate(corX2, corY2);

    }

    private void AngleCreate(int corX, int corY)
    {
        Console.SetCursorPosition(corX, corY);
        Console.WriteLine("+");

    }

}
