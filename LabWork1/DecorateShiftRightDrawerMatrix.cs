internal class DecorateShiftRightDrawerMatrix : IDrawerMatrix
{
    private IDrawerMatrix _drawerMatrix;
    private int _colShift;
    private int _rowShift;
    public int GetIndex { get; }
    public DecorateShiftRightDrawerMatrix (IDrawerMatrix drawerMatrix, int colShift, int rowShift)
    {
        _drawerMatrix = drawerMatrix;
        _colShift = colShift;
        _rowShift = rowShift;
        GetIndex = _drawerMatrix.GetIndex;

    }
    public void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        

    }
    public void DrawCellBorder(int col, int row, int maxValLength)
    {
        _drawerMatrix.DrawCellBorder(col + _colShift, row + _rowShift, maxValLength);

    }
    public void DrawContent(string cont, int col, int row, int maxValLength)
    {
        _drawerMatrix.DrawContent(cont, col + _colShift, row + _rowShift, maxValLength);

    }
    public IDrawerMatrix GetComponent()
    {
        return _drawerMatrix;

    }

}