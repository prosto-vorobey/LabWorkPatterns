//Применять не к матрице, а к отображению матрицы
/*public class DecoratorTransposeMatrix : IMatrix
{
    IMatrix _matrix;
    public int NumColumns { get; }
    public int NumRows { get; }
    public DecoratorTransposeMatrix (IMatrix matrix)
    {
        _matrix = matrix;
        NumColumns = matrix.NumRows;
        NumRows = matrix.NumColumns;

    }
    public IMatrix GetComponent()
    {
        return _matrix;

    }
    public void Set(int col, int row, int val)
    {
        _matrix.Set(col, row, val);

    }
    public int Get(int col, int row)
    {
        return _matrix.Get(row, col);

    }
    public void DrawWithoutBorder()
    {
        _matrix.DrawWithoutBorder();

    }
    public void DrawWithBorder()
    {
        _matrix.DrawWithBorder();

    }
    public void DrawWithDoubleBorder()
    {
        _matrix.DrawWithDoubleBorder();

    }

}*/