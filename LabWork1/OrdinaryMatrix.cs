using System;
using System.Windows;

public class OrdinaryMatrix : AMatrix
{
    private IVector[] _vectors;
    private IMatrixDrawStrategy _strategy;
    public OrdinaryMatrix(int cols, int rows)
    {
        _strategy = new LeafMatrixDrawStrategy(this, new OrdinaryDraw(this));
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
        _strategy.Draw(this, drawerMatrix);

    }
    public override IMatrixDrawStrategy GetMatrixStrategy()
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
            drawerMatrix.DrawCellBorder(col, row, _matrix.GetLenghtMaxVal());
            drawerMatrix.DrawContent(val.ToString(), col, row, _matrix.GetLenghtMaxVal());

        }

    }

}
