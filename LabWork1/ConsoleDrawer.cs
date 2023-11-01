using System;

public class ConsoleDrawer : IDrawer
{
    private IPrimitiveLine _primitiveLine = new PrimitiveLineScheme1();
    private IPrimitiveAngles _primitiveAngle = new PrimitiveAngles();
    private int _cellHeight = 2;
    private int _firstCorX = 0;
    private int _firstCorY = 0;
    public void Content(string cont, int col, int row, int maxValLength)
    {
        int cellLenght = maxValLength + 2;
        int corX = (col + 1) * cellLenght + _firstCorX;
        int corY = (row + 1) * _cellHeight + _firstCorY;
        int contLenght = cont.Length;
        Console.SetCursorPosition(corX - contLenght, corY);
        Console.WriteLine(cont);

    }
    public void Border (int numCols, int numRows, int maxValLength)
    {
        int cellLenght = maxValLength + 2;
        int corX1 = _firstCorX;
        int corY1 = _firstCorY;
        int corX2 = numCols * cellLenght + 1 + _firstCorX;
        int corY2 = (numRows + 1) * _cellHeight + _firstCorY;
        _primitiveAngle.Angles(corX1, corX2, corY1, corY2);
        _primitiveLine.LineHorizontal(corX1 + 1, corY1, corX2 - 1);
        _primitiveLine.LineHorizontal(corX1 + 1, corY2, corX2 - 1);
        _primitiveLine.LineVertical(corX1, corY1 + 1, corY2 - 1);
        _primitiveLine.LineVertical(corX2, corY1 + 1, corY2 - 1);

    }
    public void DoubleBorder(int numCols, int numRows, int maxValLength)
    {
        int cellLenght = maxValLength + 2;
        int corX1 = _firstCorX;
        int corY1 = _firstCorY;
        int corX2 = numCols * cellLenght;
        int corY2 = (numRows + 1) * _cellHeight - 1;
        IPrimitiveLine primitiveDecorator = new DecoratorDoubleLine(_primitiveLine);
        _primitiveAngle.Angles(corX1, corX2 + 1, corY1, corY2 + 1);
        primitiveDecorator.LineHorizontal(corX1 + 1, corY1, corX2);
        primitiveDecorator.LineHorizontal(corX1 + 1, corY2, corX2);
        primitiveDecorator.LineVertical(corX1, corY1 + 1, corY2);
        primitiveDecorator.LineVertical(corX2, corY1 + 1, corY2);
        _primitiveAngle.Angles(corX1 + 1, corX2, corY1 + 1, corY2);

    }
    

}
