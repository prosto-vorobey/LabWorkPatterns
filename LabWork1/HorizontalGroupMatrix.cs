using System;
using System.Collections.Generic;

public class HorizontalGroupMatrix : IMatrix
{
    private List<IMatrix> _matrixes = new List<IMatrix>();
    private IMatrixDrawElementStrategy _strategy;
    public HorizontalGroupMatrix()
    {
        _strategy = new CompositeMatrixDraw(this);

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
        for (int i = 0; i < NumColumns; i++)
        {
            for (int j = 0; j < NumRows; j++)
            {
                int num = Get(i, j);
                _strategy.Draw(num, i, j, drawerMatrix);

            }

        }
        drawerMatrix.DrawBorder(NumColumns, NumRows, MaxValMatrix.GetLenghtMaxVal(this));

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
            if (col >= matrix.NumColumns)
            {
                col -= matrix.NumColumns;
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
    public bool IsComposite()
    {
        return true;

    }
    public IMatrix GetComponent()
    {
        return this;

    }
    public IMatrixDrawElementStrategy GetDrawElementStrategy()
    {
        return _strategy;

    }
    public class CompositeMatrixDraw : IMatrixDrawElementStrategy
    {
        private HorizontalGroupMatrix _compositeMatrix;
        public CompositeMatrixDraw(HorizontalGroupMatrix compositeMatrix)
        {
            _compositeMatrix = compositeMatrix;

        }
        public void Draw(int val, int col, int row, IDrawerMatrix drawerMatrix)
        {
            IMatrixDrawElementStrategy drawStrategy = GetDrawElementStrategy(col, row);

            if (drawStrategy != null)
            {
                drawStrategy.Draw(val, col, row, drawerMatrix);

            }

        }
        private IMatrixDrawElementStrategy GetDrawElementStrategy(int col, int row)
        {
            IMatrixDrawElementStrategy drawStrategy = null;
            foreach (IMatrix matrix in _compositeMatrix._matrixes)
            {
                if (col >= matrix.NumColumns)
                {
                    col -= matrix.NumColumns;
                    continue;

                }
                if (row >= matrix.NumRows)
                {
                    break;

                }
                drawStrategy = matrix.GetDrawElementStrategy();
                break;

            }
            return drawStrategy;

        }

    }

}