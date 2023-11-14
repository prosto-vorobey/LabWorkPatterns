using System;
using System.Collections.Generic;

public class HorizontalGroupMatrix : IMatrix
{
    private List<IMatrix> _matrixes = new List<IMatrix>();
    private IMatrixStrategy _strategy = new CompositeMatrix();
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
        IDrawerMatrix _drawerMatrix = drawerMatrix;
        foreach (IMatrix matrix in _matrixes)
        {
            drawerMatrix = new DecorateShiftRightDrawerMatrix(drawerMatrix, shiftCol, shiftRow);
            //Разобраться со смещением при разных размерах содержимого матрицы
            matrix.Draw(drawerMatrix);
            shiftCol = matrix.NumColumns;

        }
        _strategy.Draw(this, _drawerMatrix);

    }
    public int Get(int col, int row)
    {
        int val = 0;
        foreach (IMatrix matrix in _matrixes)
        {
            if (col >= matrix.NumColumns)
            {
                col -= matrix.NumColumns;
                continue;

            }
            if (row >= matrix.NumRows)
            {
                continue;

            }
            val = matrix.Get(col, row);
            break;

        }
        return val;

    }
    public void Set(int col, int row, int val)
    {
        foreach (IMatrix matrix in _matrixes)
        {
            if (col >= matrix.NumColumns)
            {
                col -= matrix.NumColumns;
                continue;

            }
            if (row >= matrix.NumRows)
            {
                continue;

            }
            matrix.Set(col, row, val);
            break;

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

}