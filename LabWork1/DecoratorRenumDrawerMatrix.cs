public class DecoratorRenumDrawerMatrix : IDrawerMatrix
{
    private IDrawerMatrix _drawerMatrix;
    private int _col1;
    private int _row1;
    private int _col2;
    private int _row2;
    public int GetIndex { get; protected set; }
    public DecoratorRenumDrawerMatrix(IDrawerMatrix drawermatrix, int col1, int row1, int col2, int row2)
    {
        _drawerMatrix = drawermatrix;
        _col1 = col1;
        _row1 = row1;
        _col2 = col2;
        _row2 = row2;

    }
    public virtual void DrawContent(string cont, int col, int row, int maxValLength)
    {
        if (col == _col1 && row == _row1)
        {
            _drawerMatrix.DrawContent(cont, _col2, _row2, maxValLength);

        }
        else if (col == _col2 && row == _row2)
        {
            _drawerMatrix.DrawContent(cont, _col1, _row1, maxValLength);

        }
        else
        {
            _drawerMatrix.DrawContent(cont, col, row, maxValLength);

        }

    }
    public void DrawCellBorder(int col, int row, int maxValLength)
    {
        _drawerMatrix.DrawCellBorder(col, row, maxValLength);

    }
    public void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        _drawerMatrix.DrawBorder(numCols, numRows, maxValLength);

    }
    public IDrawerMatrix GetComponent()
    {
        return _drawerMatrix;

    }

}