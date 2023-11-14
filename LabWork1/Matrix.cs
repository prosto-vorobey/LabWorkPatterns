using System;

public interface IMatrix
{
    int NumColumns { get; }
    int NumRows { get; }
    int Get(int col, int row);
    void Set(int col, int row, int val);
    void Draw(IDrawerMatrix drawerMatrix);
    IMatrixStrategy GetMatrixStrategy();
    IMatrix GetComponent();

}
public class Matrix : IMatrix
{
    private IMatrixStrategy _strategy;
    private IVector[] _vectors;
    public Matrix (IMatrixStrategy matrixStrategy, int cols, int rows)
    {
        _strategy = matrixStrategy;
        NumColumns = cols;
        NumRows = rows;
        _vectors = _strategy.GetMatrixVector(NumColumns, NumRows);

    }
    public int NumColumns
    {
        get;
        protected set;

    }
    public int NumRows
    {
        get;
        protected set;

    }
    public virtual void Set(int col, int row, int val)
    {
        try
        {
            if (col > NumColumns)
            {
                throw new IndexOutOfRangeException("Введённое положение столбца выходит за границы матрицы.");

            }
            if (row > NumRows)
            {
                throw new IndexOutOfRangeException("Введённое положение строки выходит за границы матрицы.");

            }
            _vectors[col].Set(row, val);

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }

    }
    public int Get(int col, int row)
    {
        int val = 0;
        try
        {
            val = _vectors[col].Get(row);

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }
        return val;

    }
    public void Draw(IDrawerMatrix drawerMatrix)
    {
        _strategy.Draw(this, drawerMatrix);

    }
    public IMatrixStrategy GetMatrixStrategy()
    {
        return _strategy;

    }
    public IMatrix GetComponent()
    {
        return this;

    }

}
