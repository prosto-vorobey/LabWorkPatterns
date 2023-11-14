public class DecoratorTransposeMatrix : IMatrix
{
    IMatrix _matrix;
    public int NumColumns { get; }
    public int NumRows { get; }
    public DecoratorTransposeMatrix(IMatrix matrix)
    {
        _matrix = matrix;
        NumColumns = _matrix.NumRows;
        NumRows = _matrix.NumColumns;

    }
    public int Get(int col, int row)
    {
        return _matrix.Get(row, col);

    }
    public void Set(int col, int row, int val)
    {
        Set(row, col, val);

    }
    public void Draw(IDrawerMatrix drawerMatrix)
    {
        GetMatrixStrategy().Draw(this, drawerMatrix);

    }
    public IMatrix GetComponent()
    {
        return _matrix;

    }
    public IMatrixStrategy GetMatrixStrategy()
    {
        return _matrix.GetMatrixStrategy();

    }
    
}