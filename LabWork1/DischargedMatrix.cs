using static OrdinaryMatrix;

public class DischargedMatrix : AMatrix
{
    private IVector[] _vectors;
    private IMatrixDrawStrategy _strategy;
    public DischargedMatrix(int cols, int rows)
    {
        _strategy = new LeafMatrixDrawStrategy(this, new DischargedDraw(this));
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
    public override IMatrixDrawStrategy GetMatrixStrategy()
    {
        return _strategy;

    }
    protected override IVector[] GetVector()
    {
        return _vectors;

    }
    public class DischargedDraw : IMatrixDrawElementStrategy
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