public class MatrixTransposeDecorator : IMatrix
{
    IMatrix _matrix;
    public int NumColumns { get { return _matrix.NumRows; } }
    public int NumRows { get { return _matrix.NumColumns; } }
    public MatrixTransposeDecorator(IMatrix matrix)
    {
        _matrix = matrix;

    }
    public int Get(int col, int row)
    {
        return _matrix.Get(row, col);

    }
    public void Set(int col, int row, int val)
    {
        Set(row, col, val);

    }
    public void Accept(IMatrixVisitor drawer)
    {
        drawer = new MatrixVisitorTransposeDecorator(drawer);
        _matrix.Accept(drawer);

    }
    /*public void Draw(IDrawer drawerMatrix)
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

    }*/
    public HorizontalGroupMatrix GetComposite()
    {
        return _matrix.GetComposite();

    }
    public IMatrix GetComponent()
    {
        return _matrix.GetComponent();

    }

}