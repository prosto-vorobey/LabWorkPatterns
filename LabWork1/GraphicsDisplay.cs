using System.Drawing;
using System.Windows.Forms;

public class GraphicsDisplay : IDrawerDisplay
{
    private Panel _panel;
    private Graphics _graphics;
    private IGraphicsPrimitives _primitives;
    ////private int _firstCorX = 0;
    ////private int _firstCorY = 0;
    //private int _cellHeight = 4;
    private int _scaleWidth = 10;
    private int _scaleHeight = 10;

    public GraphicsDisplay(Panel panel)
    {
        _panel = panel;
        _graphics = _panel.CreateGraphics();
        _primitives = new GraphicsPrimitives(_graphics);

    }
    public void Content(string cont, int corCellX, int corCellY)
    {
        int contLenght = cont.Length;
        int corX = (corCellX - contLenght) * _scaleWidth;
        int corY = corCellY * _scaleHeight + _scaleHeight;
        _primitives.TextCell(cont, corX, corY);

    }
    public void Border(int width, int height)
    {
        int corX1 = 0;
        int corY1 = 0;
        int corX2 = width * _scaleWidth;
        int corY2 = height * _scaleHeight;
        _primitives.Line(corX1, corY1, corX2, corY1);
        _primitives.Line(corX1, corY2, corX2, corY2);
        _primitives.Line(corX1, corY1, corX1, corY2);
        _primitives.Line(corX2, corY1, corX2, corY2);

    }

}