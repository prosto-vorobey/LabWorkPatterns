using System;
using System.Drawing;

public class DecoratorRenumMatrix : IMatrix
{
    private IMatrix _matrix;
    private Random rnd = new Random();
    private int _col1;
    private int _row1;
    private int _col2;
    private int _row2;
    public int NumColumns { get; }
    public int NumRows { get; }
    public DecoratorRenumMatrix (IMatrix matrix)
    {
        _matrix = matrix;
        NumColumns = _matrix.NumColumns;
        NumRows = _matrix.NumRows;
        _col1 = rnd.Next(_matrix.NumColumns);
        _row1 = rnd.Next(_matrix.NumRows);
        _col2 = rnd.Next(_matrix.NumColumns);
        _row2 = rnd.Next(_matrix.NumRows);

    }
    public int Get(int col, int row)
    {
        int val;
        if (col == _col1 && row == _row1)
        {
            val = _matrix.Get(_col2, _row2);

        }
        else if (col == _col2 && row == _row2)
        {
            val = _matrix.Get(_col1, _row1);

        }
        else
        {
            val = _matrix.Get(col, row);

        }
        return val;

    }
    public void Set(int col, int row, int val)
    {
        if (col == _col1 && row == _row1)
        {
            _matrix.Set(_col2, _row2, val);

        }
        else if(col == _col2 && row == _row2)
        {
            _matrix.Set(_col1, _row1, val);

        }
        else
        {
            _matrix.Set(col, row, val);

        }

    }
    public void Draw(IDrawerMatrix drawerMatrix)
    {
        _matrix.GetMatrixStrategy().Draw(this, drawerMatrix);
        MessageWarning.MessageOutRange($"Перенумерованы ячейки: {_col1 + 1}, {_row1 + 1}({_matrix.Get(_col1, _row1)}) и {_col2 + 1}, {_row2 + 1}({Get(_col1, _row1)})");

    }
    public IMatrixStrategy GetMatrixStrategy()
    {
        return _matrix.GetMatrixStrategy();

    }
    public IMatrix GetComponent()
    {
        return _matrix;

    }

}