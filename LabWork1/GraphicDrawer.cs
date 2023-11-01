using System.Windows.Forms;
using System.Drawing;
using System;

public class GraphicDrawer : IDrawer
{
    private Panel _panel;
    private Graphics _graphics;
    private IGraphicsPrimitives _primitives;
    private int _firstCorX = 0;
    private int _firstCorY = 0;
    private int _cellHeight = 4;
    private int _scaleWidth = 10;
    private int _scaleHeight = 10;

    public GraphicDrawer(Panel panel)
    {
        _panel = panel;
        _graphics = _panel.CreateGraphics();
        _primitives = new GraphicsPrimitives(_graphics);

    }
    public void Content(string cont, int col, int row, int maxValLength)
    {
        int contLenght = cont.Length;
        int cellWidth = maxValLength + 2;
        int corX = col * cellWidth * _scaleWidth + _scaleWidth + _firstCorX;
        int corY = row * _cellHeight * _scaleHeight + _scaleHeight + _firstCorY;
        _primitives.TextCell(cont, corX - contLenght, corY);

    }
    public void Border(int numCols, int numRows, int maxValLength)
    {
        int cellWidth = maxValLength + 2;
        int corX1 = _firstCorX * _scaleWidth;
        int corY1 = _firstCorY * _scaleHeight;
        int corX2 = numCols * cellWidth * _scaleWidth + _firstCorX;
        int corY2 = numRows * _cellHeight * _scaleHeight + _firstCorY;
        _primitives.Line(corX1, corY1, corX2, corY1);
        _primitives.Line(corX1, corY2, corX2, corY2);
        _primitives.Line(corX1, corY1, corX1, corY2);
        _primitives.Line(corX2, corY1, corX2, corY2);

    }
/*    public void DoubleBorder(int numCols, int numRows, int maxValLength)
    {
        IPrimitiveLine primitiveDecorator = new DecoratorDoubleLine(_primitive);
        int cellWidth = maxValLength + 2;
        int corX1 = _firstCorX * _scaleWidth;
        int corY1 = _firstCorY * _scaleHeight;
        int corX2 = numCols * cellWidth * _scaleWidth + _firstCorX;
        int corY2 = numRows * _cellHeight * _scaleHeight + _firstCorY;
        _primitive.LineHorizontal(corX1, corY1, corX2);
        _primitive.LineHorizontal(corX1, corY2, corX2);
        _primitive.LineVertical(corX1, corY1, corY2);
        _primitive.LineVertical(corX2, corY1, corY2);

    }*/

}