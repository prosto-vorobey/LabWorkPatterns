using System.Drawing;

public interface IGraphicsPrimitives
{
    int GetIndex { get; }
    void TextCell(Graphics graphics, string text, int corX, int corY);
    void Line(Graphics graphics, int corX1, int corY1, int corX2, int corY2);

}
public class GraphicsPrimitives : IGraphicsPrimitives
{
    private Font _fontArial;
    private Pen _pen;
    private int _sizeFont = 9;
    private int _penSize = 3;
    public GraphicsPrimitives()
    {
        _pen = new Pen(Color.Black, _penSize);
        GetIndex = 0;

    }
    public int GetIndex { get; }
    public void TextCell(Graphics graphics, string text, int corX, int corY)
    {
        _fontArial = new Font("Arial", _sizeFont);
        Brush brush = new SolidBrush(Color.Black);
        graphics.DrawString(text, _fontArial, brush, corX, corY);

    }
    public void Line(Graphics graphics, int corX1, int corY1, int corX2, int corY2)
    {
        Point point1 = new Point(corX1 + _penSize, corY1 + _penSize);
        Point point2 = new Point(corX2 + _penSize, corY2 + _penSize);
        graphics.DrawLine(_pen, point1, point2);

    }

}
