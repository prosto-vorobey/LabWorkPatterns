using System;

public interface IMatrix
{
    int NumColumns { get; }
    int NumRows { get; }
    int Get(int col, int row);
    void Set(int col, int row, int val);
    void Draw(IDrawerMatrix drawerMatrix);
    bool IsComposite();
    IMatrixDrawStrategy GetMatrixStrategy();
    IMatrix GetComponent();

}
public abstract class AMatrix : IMatrix
{
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
    public void Set(int col, int row, int val)
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
            GetVector()[col].Set(row, val);

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
            val = GetVector()[col].Get(row);

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }
        return val;

    }
    public abstract void Draw(IDrawerMatrix drawerMatrix);
    public bool IsComposite()
    {
        return false;

    }
    public abstract IMatrixDrawStrategy GetMatrixStrategy();
    public IMatrix GetComponent()
    {
        return this;

    }
    protected abstract IVector[] GetVector();
    protected int GetLenghtMaxVal()
    {
        int valMax = new MatrixStatistic(this).ValMax;
        int maxValLenght = NumLenght.GetLenght(valMax);
        return maxValLenght;

    }
    public class LeafMatrixDrawStrategy : IMatrixDrawStrategy
    {
        private AMatrix _matrix;
        private IMatrixDrawElementStrategy _drawStrategy;
        public LeafMatrixDrawStrategy(AMatrix matrix, IMatrixDrawElementStrategy drawStrategy)
        {
            _matrix = matrix;
            _drawStrategy = drawStrategy;

        }
        public void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix)
        {
            for (int i = 0; i < matrix.NumColumns; i++)
            {
                for (int j = 0; j < matrix.NumRows; j++)
                {
                    int num = matrix.Get(i, j);
                    _drawStrategy.Draw(num, i, j, drawerMatrix);

                }

            }
            drawerMatrix.DrawBorder(matrix.NumColumns, matrix.NumRows, _matrix.GetLenghtMaxVal());

        }
        public IMatrixDrawElementStrategy GetDrawElementStrategy()
        {
            return _drawStrategy;

        }

    }

}
