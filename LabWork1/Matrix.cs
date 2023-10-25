using System;

public interface IMatrix
{
    int NumColumns { get; }
    int NumRows { get; }
    int Get(int col, int row);
    void Set(int col, int row, int val);
    void Draw();
    void DrawWithBorder();
    void DrawWithoutBorder();
    void DrawWithDoubleBorder();
    IMatrix GetComponent();

}
public abstract class AMatrix : IMatrix
{
    private IDrawer _scheme;
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
    public virtual void Set(int col, int row, int val)
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
            GetMatrixVector()[col].Set(row, val);

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
            val = GetMatrixVector()[col].Get(row);

        }
        catch (Exception ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }
        return val;

    }
    protected abstract IVector[] GetMatrixVector();

    public void Draw()
    {
        paintBorder(this);
        for (int i = 0; i < NumRows; i++)
        {
            for (int j = 0; j < NumColumns; j++)
            {
                paintCellValue(this, i, j);
            }

        }
    }

    interface IPainter
    {
        void paintCellValue(IMatrix aMatrix, int i, int j);
        void paintBorder(IMatrix aMatrix);
    }

    private IPainter painter;

    private void paintCellValue(IMatrix aMatrix, int i, int j)
    {
        painter.paintCellValue(aMatrix, i, j);
    }

    protected abstract void paintBorder(IMatrix aMatrix);

    public abstract void DrawWithBorder();
    public abstract void DrawWithoutBorder();
    public abstract void DrawWithDoubleBorder();
    public IMatrix GetComponent()
    {
        return this;

    }
    protected void Content(IDrawer scheme, string cont, int col, int row, int maxValLenght)
    {
        _scheme = scheme;
        _scheme.Content(cont, col, row, maxValLenght);

    }
    protected void Border(IDrawer scheme, int maxValLenght)
    {
        _scheme = scheme;
        _scheme.Border(NumColumns, NumRows, maxValLenght);

    }
    protected void DoubleBorder(IDrawer scheme, int maxValLenght)
    {
        _scheme = scheme;
        _scheme.DoubleBorder(NumColumns, NumRows, maxValLenght);

    }
    protected int GetLenghtMaxVal()
    {
        int valMax = new MatrixStatistic(this).ValMax;
        int maxValLenght = NumLenght.GetLenght(valMax);
        return maxValLenght;

    }

}
