using System.Collections.Generic;

public class HorizontalGroupMatrix : IMatrix
{
    private List<IMatrix> _matrixes = new List<IMatrix>();
    private IMatrixStrategy _strategy;
    public HorizontalGroupMatrix()
    {
        _strategy = new CompositeMatrix(this);

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
        _strategy.Draw(this, drawerMatrix);

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
    public bool IsComposite()
    {
        return true;

    }
    public IMatrix GetComponent()
    {
        return this;

    }
    public IMatrixStrategy GetMatrixStrategy()
    {
        return _strategy;

    }
    public class CompositeMatrix : IMatrixStrategy
    {
        private HorizontalGroupMatrix _compositeMatrix;
        public CompositeMatrix(HorizontalGroupMatrix compositeMatrix)
        {
            _compositeMatrix = compositeMatrix;

        }
        public void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix)
        {
            int shiftCol = 0;
            int shiftRow = 0;
            IDrawerMatrix _drawerMatrix = drawerMatrix;
            foreach (IMatrix someMatrix in _compositeMatrix._matrixes)
            {
                for (int i = 0; i < someMatrix.NumColumns; i++)
                {
                    for (int j = 0; j < someMatrix.NumRows; j++)
                    {
                        int num = matrix.Get(i, j);
                        drawerMatrix = new DecorateShiftRightDrawerMatrix(drawerMatrix, shiftCol, shiftRow);
                        someMatrix.GetMatrixStrategy().GetDrawStrategy().Draw(num, i, j, drawerMatrix);

                    }

                }
                //Разобраться со смещением при разных размерах содержимого матрицы
                shiftCol = someMatrix.NumColumns;

            }
            //drawerMatrix.DrawBorder(matrix.NumColumns, matrix.NumRows, GetLenghtMaxVal());

        }
        public IDrawMatrixStrategy GetDrawStrategy()
        {
            throw new System.NotImplementedException();

        }

    }

}