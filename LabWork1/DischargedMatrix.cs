public class DischargedMatrix : AMatrix
{
    private IVector[] _vectors;
    private IMatrixStrategy _strategy;
    public DischargedMatrix(int cols, int rows)
    {
        _strategy = new DischargedMatrixStrategy(this);
        NumColumns = cols;
        NumRows = rows;
        _vectors = new DischargedVector[cols];
        for (int i = 0; i < cols; i++)
        {
            _vectors[i] = new DischargedVector(rows);

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
    public class DischargedMatrixStrategy : IMatrixStrategy
    {
        private DischargedMatrix _matrix;
        private IDrawMatrixStrategy _drawStrategy;
        public DischargedMatrixStrategy(DischargedMatrix matrix)
        {
            _matrix = matrix;
            _drawStrategy = new DischargedDraw(_matrix);

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
        public class DischargedDraw : IDrawMatrixStrategy
        {
            private DischargedMatrix _matrix;
            public DischargedDraw(DischargedMatrix matrix)
            {
                _matrix = matrix;

            }
            public void Draw(int val, int col, int row, IDrawerMatrix drawerMatrix)
            {
                drawerMatrix.DrawCellBorder(col, row, _matrix.GetLenghtMaxVal());
                if (val == 0)
                {
                    return;

                }
                drawerMatrix.DrawContent(val.ToString(), col, row, _matrix.GetLenghtMaxVal());

            }

        }

    }

}