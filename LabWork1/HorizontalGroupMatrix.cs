using System;
using System.Collections.Generic;

public class HorizontalGroupMatrix : ICompositeMatrix
{
    private List<IMatrix> _matrixes = new List<IMatrix>();
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
                int numRows = matrix.NumRows;
                if (numRows > maxNumRows)
                {
                    maxNumRows = numRows;

                }

            }
            return maxNumRows;

        }

    }
    public void AddMatrix(IMatrix matrix)
    {
        _matrixes.Add(matrix);

    }
    public int Get(int col, int row)
    {
        int val = 0;
        foreach (IMatrix matrix in _matrixes)
        {
            int numColumns = matrix.NumColumns;
            if (col >= numColumns)
            {
                col -= numColumns;
                continue;

            }
            if (row >= matrix.NumRows)
            {
                break;

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
            int numColumns = matrix.NumColumns;
            if (col >= numColumns)
            {
                col -= numColumns;
                continue;

            }
            if (row >= matrix.NumRows)
            {
                break;

            }
            matrix.Set(col, row, val);
            break;

        }

    }
    public void Accept(IMatrixVisitor visitor)
    {
        foreach (IMatrix matrix in _matrixes)
        {
            matrix.Accept(visitor);

        }

    }
    public ICompositeMatrix GetComposite()
    {
        return this;

    }
    public IMatrix GetComponent()
    {
        return this;

    }
    public IMatrixIterator CreateIterator()
    {
        return new CompositeMatrixIterator(this);

    }
    public IMatrix GetMatrix(int current)
    {
        return _matrixes[current];

    }
    public int Count()
    {
        return _matrixes.Count;

    }

}