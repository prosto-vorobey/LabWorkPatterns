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
        for (int i = 0; i < NumColumns; i++)
        {
            for (int j = 0; j < NumRows; j++)
            {
                //Сначала запрашиваем стратегию матрицы для старых координат, потом отрисовываем в новых. Подумать как! 
                int num = Get(i, j);
                GetDrawElementStrategy().Draw(num, i, j, drawerMatrix);

            }

        }
        drawerMatrix.DrawBorder(NumColumns, NumRows, MaxValMatrix.GetLenghtMaxVal(this));

    }
    public bool IsComposite()
    {
        return _matrix.IsComposite();

    }
    public IMatrix GetComponent()
    {
        return _matrix;

    }
    public IMatrixDrawElementStrategy GetDrawElementStrategy()
    {
        return _matrix.GetDrawElementStrategy();

    }

}