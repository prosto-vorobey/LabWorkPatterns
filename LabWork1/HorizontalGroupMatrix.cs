using System;
using System.Collections.Generic;

public class HorizontalGroupMatrix : IMatrix, IIterable
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
    /*public void Draw(IDrawer drawerMatrix)
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

    }*/
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
    public void Accept(IMatrixVisitor drawer)
    {
        foreach (IMatrix matrix in _matrixes)
        {
            matrix.Accept(drawer);
            //drawer = new MatrixVisitorShiftRightDecorator(drawer, matrix.NumColumns);

        }

    }
    /*public bool IsComposite()
    {
        return true;

    }*/
    public HorizontalGroupMatrix GetComposite()
    {
        return this;

    }
    public IMatrix GetComponent()
    {
        return this;

    }
    public IIteratorMatrix CreateIterator()
    {
        return new CompositeMatrixIterator(_matrixes);

    }
    /*public class CompositeMatrixDraw : IMatrixDrawElementStrategy
{
   private HorizontalGroupMatrix _compositeMatrix;
   public CompositeMatrixDraw(HorizontalGroupMatrix compositeMatrix)
   {
       _compositeMatrix = compositeMatrix;

   }
   public void Draw(int val, int col, int row, IDrawer drawerMatrix)
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

}*/

}