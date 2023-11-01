using System.Drawing;

public interface IGraphicsPrimitives
{
    void TextCell(string text, int corX, int corY);
    void Line(int corX1, int corY1, int corX2, int corY2);

}
public class GraphicsPrimitives : IGraphicsPrimitives
{
    private Graphics _graphics;
    private Font _fontArial;
    private Pen _pen;
    private int _sizeFont = 9;
    private int _penSize = 3;
    public GraphicsPrimitives(Graphics graphics)
    {
        _graphics = graphics;
        _pen = new Pen(Color.Black, _penSize);

    }
    public void TextCell(string text, int corX, int corY)
    {
        _fontArial = new Font("Arial", _sizeFont);
        Brush brush = new SolidBrush(Color.Black);
        _graphics.DrawString(text, _fontArial, brush, corX, corY);

    }
    public void Line(int corX1, int corY1, int corX2, int corY2)
    {
        Point point1 = new Point(corX1 + _penSize, corY1 + _penSize);
        Point point2 = new Point(corX2 + _penSize, corY2 + _penSize);
        _graphics.DrawLine(_pen, point1, point2);

    }

}