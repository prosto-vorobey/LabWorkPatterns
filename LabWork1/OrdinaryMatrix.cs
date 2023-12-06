using System;
using System.Windows;

public class OrdinaryMatrix : AMatrix
{
    private IVector[] _vectors;
    private IMatrixDrawElementStrategy _strategy;
    public OrdinaryMatrix(int cols, int rows)
    {
        _strategy = new OrdinaryDraw(this);
        NumColumns = cols;
        NumRows = rows;
        _vectors = new OrdinaryVector[cols];
        for (int i = 0; i < cols; i++)
        {
            _vectors[i] = new OrdinaryVector(rows);

        }

    }
    public override void Draw(IDrawerMatrix drawerMatrix)
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
    public override IMatrixDrawElementStrategy GetDrawElementStrategy()
    {
        return _strategy;

    }
    protected override IVector[] GetVector()
    {
       return _vectors;

    }
    public class OrdinaryDraw : IMatrixDrawElementStrategy
    {
        private OrdinaryMatrix _matrix;
        public OrdinaryDraw(OrdinaryMatrix matrix)
        {
            _matrix = matrix;

        }
        public void Draw(int val, int col, int row, IDrawerMatrix drawerMatrix)
        {
            drawerMatrix.DrawCellBorder(col, row, MaxValMatrix.GetLenghtMaxVal(_matrix));
            drawerMatrix.DrawContent(val.ToString(), col, row, MaxValMatrix.GetLenghtMaxVal(_matrix));

        }

    }

}
