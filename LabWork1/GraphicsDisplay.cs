using System.Drawing;
using System.Windows.Forms;

public class GraphicsDisplay : IDrawerDisplay
{
    private Graphics _graphics;
    private IGraphicsPrimitives _primitives;
    ////private int _firstCorX = 0;
    ////private int _firstCorY = 0;
    //private int _cellHeight = 4;
    private int _scaleWidth = 10;
    private int _scaleHeight = 10;
    public GraphicsDisplay(Panel panel, IGraphicsPrimitives primitives)
    {
        _graphics = panel.CreateGraphics();
        _primitives = primitives;
        _primitives = new GraphicsPrimitives();
        GetIndex = 1;

    }
    public int GetIndex { get; }
    public void Content(string cont, int corCellX, int corCellY)
    {
        int contLenght = cont.Length;
        int corX = (corCellX - contLenght) * _scaleWidth;
        int corY = corCellY * _scaleHeight + _scaleHeight;
        _primitives.TextCell(_graphics, cont, corX, corY);

    }
    public void Border(int corX1, int corY1, int corX2, int corY2)
    {
        corX1 *= _scaleWidth;
        corY1 = (corY1 + 1) * _scaleHeight;
        corX2 *= _scaleWidth;
        corY2 = (corY2 + 1) * _scaleHeight;
        _primitives.Line(_graphics, corX1, corY1, corX2, corY1);
        _primitives.Line(_graphics, corX1, corY2, corX2, corY2);
        _primitives.Line(_graphics, corX1, corY1, corX1, corY2);
        _primitives.Line(_graphics, corX2, corY1, corX2, corY2);

    }

}