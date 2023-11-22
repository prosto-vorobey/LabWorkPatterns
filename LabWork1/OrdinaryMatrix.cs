using System;
using System.Windows;

public class OrdinaryMatrix : AMatrix
{
    private IVector[] _vectors;
    private IMatrixStrategy _strategy;
    public OrdinaryMatrix(int cols, int rows)
    {
        _strategy = new OrdinaryMatrixStrategy(this);
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
    public override IMatrixStrategy GetMatrixStrategy()
    {
        return _strategy;

    }
    protected override IVector[] GetVector()
    {
       return _vectors;

    }
    public class OrdinaryMatrixStrategy : IMatrixStrategy
    {
        private OrdinaryMatrix _matrix;
        private IDrawMatrixStrategy _drawStrategy;
        public OrdinaryMatrixStrategy(OrdinaryMatrix matrix)
        {
            _matrix = matrix;
            _drawStrategy = new OrdinaryDraw(_matrix);

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
        public IDrawMatrixStrategy GetDrawStrategy()
        {
            return _drawStrategy;

        }
        public class OrdinaryDraw : IDrawMatrixStrategy
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

}
