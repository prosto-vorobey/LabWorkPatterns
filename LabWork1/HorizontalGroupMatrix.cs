using System;
using System.Collections.Generic;

public class HorizontalGroupMatrix : IMatrix
{
    private List<IMatrix> _matrixes = new List<IMatrix>();
    private IMatrixDrawStrategy _strategy;
    public HorizontalGroupMatrix()
    {
        _strategy = new CompositeMatrixDrawStrategy(this);

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
    public IMatrixDrawStrategy GetMatrixStrategy()
    {
        return _strategy;

    }
    protected int GetLenghtMaxVal(IMatrix matrix)
    {
        int valMax = new MatrixStatistic(matrix).ValMax;
        int maxValLenght = NumLenght.GetLenght(valMax);
        return maxValLenght;

    }
    public class CompositeMatrixDrawStrategy : IMatrixDrawStrategy
    {
        private HorizontalGroupMatrix _compositeMatrix;
        public CompositeMatrixDrawStrategy(HorizontalGroupMatrix compositeMatrix)
        {
            _compositeMatrix = compositeMatrix;

        }
        public void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix)
        {
            //int shiftCol = 0;
            //int shiftRow = 0;
            int corX = -1;
            int corY = 0;
            IDrawerMatrix _drawerMatrix = drawerMatrix;
            foreach (IMatrix someMatrix in _compositeMatrix._matrixes)
            {
                //drawerMatrix = new DecorateShiftRightDrawerMatrix(drawerMatrix, shiftCol, shiftRow);
                for (int i = 0; i < someMatrix.NumColumns; i++)
                {
                    corX ++;
                    int curRow = 0;
                    while(curRow != matrix.NumRows)
                    {
                        corY = curRow;
                        int num = matrix.Get(corX, corY);
                        if (corY < someMatrix.NumRows)
                        {
                            someMatrix.GetMatrixStrategy().GetDrawElementStrategy().Draw(num, corX, corY, drawerMatrix);

                        }
                        else
                        {
                            drawerMatrix.DrawCellBorder(corX, corY, _compositeMatrix.GetLenghtMaxVal(someMatrix));
                            if (num != 0)
                            {
                                drawerMatrix.DrawContent(num.ToString(), corX, corY, _compositeMatrix.GetLenghtMaxVal(someMatrix));

                            }

                        }
                        curRow++;

                    }

                }
                //Разобраться со смещением при разных размерах содержимого матрицы
                //shiftCol = someMatrix.NumColumns;

            }
            _drawerMatrix.DrawBorder(matrix.NumColumns, matrix.NumRows, _compositeMatrix.GetLenghtMaxVal(_compositeMatrix));

        }
        public IMatrixDrawElementStrategy GetDrawElementStrategy()
        {
            throw new System.NotImplementedException();

        }

    }

}