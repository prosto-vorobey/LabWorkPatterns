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
    public void Accept(IMatrixVisitor visitor)
    {
        visitor = new MatrixVisitorTransposeDecorator(visitor);
        if (_matrix.GetComposite() != null)
        {
            IIterable iterable = _matrix.GetComposite();
            IMatrixIterator iterator = iterable.CreateIterator();
            IMatrix someMatrix;
            while (!iterator.IsDone())
            {
                someMatrix = iterator.GetCurrent();
                someMatrix.Accept(visitor);
                iterator.MoveNext();

            }

        }
        else
        {
            _matrix.Accept(visitor);

        }

    }
    public ICompositeMatrix GetComposite()
    {
        return _matrix.GetComposite();

    }
    public IMatrix GetComponent()
    {
        return _matrix.GetComponent();

    }

}