using System;
using System.Drawing;

public class DecoratorRenumMatrix : IMatrix
{
    private IMatrix _matrix;
    private IDrawerMatrix _drawerMatrix;
    private int _col1;
    private int _row1;
    private int _col2;
    private int _row2;
    private Random rnd = new Random();
    public int NumColumns { get; }
    public int NumRows { get; }
    public DecoratorRenumMatrix (IMatrix matrix)
    {
        _matrix = matrix;
        NumColumns = _matrix.NumColumns;
        NumRows = _matrix.NumRows;
        _col1 = rnd.Next(NumColumns);
        _row1 = rnd.Next(NumRows);
        _col2 = rnd.Next(NumColumns);
        _row2 = rnd.Next(NumRows);
    }
    public void Draw(IDrawerMatrix drawerMatrix)
    {
        _drawerMatrix = new DecoratorRenumDrawerMatrix(drawerMatrix, _col1, _row1, _col2, _row2);
        _matrix.Draw(_drawerMatrix);
        MessageWarning.MessageOutRange($"Перенумерованы ячейки: {_col1}, {_row1}({_matrix.Get(_col1, _row1)}) и {_col2}, {_row2}({Get(_col1, _row1)})");

    }
    public int Get(int col, int row)
    {
        int val = 0;
        if (col == _col1 && row == _row1)
        {
            val = _matrix.Get(_col2, _row2);

        }
        if (col == _col2 && row == _row2)
        {
            val = _matrix.Get(_col1, _row1);

        }
        return val;

    }
    public IMatrix GetComponent()
    {
        return _matrix;

    }
    public void Set(int col, int row, int val)
    {
        if (col == _col1 && row == _row1)
        {
            _matrix.Set(_col2, _row2, val);

        }
        if (col == _col2 && row == _row2)
        {
            _matrix.Set(_col1, _row1, val);

        }

    }

}