using System;
using System.Collections.Generic;

public class HorizontalGroupMatrix : IMatrix
{
    private List<IMatrix> _matrixes = new List<IMatrix>();
    private IMatrixStrategy _strategy;
    public HorizontalGroupMatrix()
    {
        _strategy = new CompositeMatrix();

    }
    public int NumColumns
    {
        get
        {
            int sumNumCols = 0;
            foreach (IMatrix matrix in _matrixes)
            {
                sumNumCols += matrix.NumColumns;

            }
            return sumNumCols;

        }

    }
    public int NumRows
    {
        get
        {
            int maxNumRows = 0;
            foreach (IMatrix matrix in _matrixes)
            {
                if (matrix.NumRows > maxNumRows)
                {
                    maxNumRows = matrix.NumRows;

                }

            }
            return maxNumRows;

        }

    }
    public void AddMatrix(IMatrix matrix)
    {
        _matrixes.Add(matrix);

    }
    public void Draw(IDrawerMatrix drawerMatrix)
    {
        int shiftCol = 0;
        int shiftRow = 0;
        drawerMatrix = new DecorateShiftRightDrawerMatrix(drawerMatrix, shiftCol, shiftRow);
        foreach (IMatrix matrix in _matrixes)
        {
            matrix.Draw(drawerMatrix);
            shiftCol += matrix.NumColumns;

        }
        _strategy.Draw(this, drawerMatrix);

    }
    public int Get(int col, int row)
    {
        int val = 0;
        IMatrix matrix = GetNeedMatrix(col, row);
        if (matrix != null)
        {
            val = matrix.Get(col, row);

        }
        return val;

    }
    public void Set(int col, int row, int val)
    {
        IMatrix matrix = GetNeedMatrix(col, row);
        if (matrix != null)
        {
            matrix.Set(col, row, val);

        }

    }
    public IMatrix GetComponent()
    {
        return this;

    }
    public IMatrixStrategy GetMatrixStrategy()
    {
        return _strategy;

    }
    protected IMatrix GetNeedMatrix(int col, int row)
    {
        IMatrix _matrix = null;
        foreach (IMatrix matrix in _matrixes)
        {
            if (col <= matrix.NumColumns)
            {
                col -= matrix.NumColumns;
                continue;

            }
            if (row > matrix.NumRows)
            {
                continue;

            }
            _matrix = matrix;
            break;

        }
        return _matrix;

    }

}