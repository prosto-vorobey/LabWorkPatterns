using System.Windows.Forms;
using System.Drawing;
using System;

public class GraphicDrawer : IDrawer
{
    private Panel _panel;
    private Graphics _graphics;
    private Font _fontArial;
    private IPrimitiveLine _primitive;
    private int _sizeFont = 9;
    private int _firstCorX = 0;
    private int _firstCorY = 0;
    private int _cellHeight = 4;
    private int _scaleWidth = 10;
    private int _scaleHeight = 10;

    public GraphicDrawer(Panel panel)
    {
        _panel = panel;
        _graphics = _panel.CreateGraphics();
        _primitive = new PrimitiveLineScheme2(_graphics);

    }
    public void Content(string cont, int col, int row, int maxValLength)
    {
        _fontArial = new Font("Arial", _sizeFont);
        int contLenght = cont.Length;
        int cellWidth = maxValLength + 2;
        int corX = col * cellWidth * _scaleWidth + _scaleWidth + _firstCorX;
        int corY = row * _cellHeight * _scaleHeight + _scaleHeight + _firstCorY;
        Brush brush = new SolidBrush(Color.Black);
        _graphics.DrawString(cont, _fontArial, brush, corX - contLenght, corY);

    }
    public void Border(int numCols, int numRows, int maxValLength)
    {
        int cellWidth = maxValLength + 2;
        int corX1 = _firstCorX * _scaleWidth;
        int corY1 = _firstCorY * _scaleHeight;
        int corX2 = numCols * cellWidth * _scaleWidth + _firstCorX;
        int corY2 = numRows * _cellHeight * _scaleHeight + _firstCorY;
        _primitive.LineHorizontal(corX1, corY1, corX2);
        _primitive.LineHorizontal(corX1, corY2, corX2);
        _primitive.LineVertical(corX1, corY1, corY2);
        _primitive.LineVertical(corX2, corY1, corY2);

    }
    public void DoubleBorder(int numCols, int numRows, int maxValLength)
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

    }

}