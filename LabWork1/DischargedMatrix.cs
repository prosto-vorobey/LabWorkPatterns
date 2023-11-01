public class DischargedMatrix : AMatrix
{
    private IDrawer _scheme;
    private IVector[] _vectors;
    public DischargedMatrix(int cols, int rows, IDrawer scheme = null)
    {
        NumColumns = cols;
        NumRows = rows;
        _scheme = scheme;
        _vectors = new DischargedVector[NumColumns];
        for (int i = 0; i < NumColumns; i++)
        {
            _vectors[i] = new DischargedVector(NumRows);

        }

    }
    public override void Draw()
    {
        base.Draw();
        for (int i = 0; i < NumColumns; i++)
        {
            for (int j = 0; j < NumRows; j++)
            {
                int num = Get(i, j);
                if (num == 0)
                {
                    continue;

                }
                Content(num.ToString(), i, j, GetLenghtMaxVal());

            }

        }

    }
    protected override IVector[] GetMatrixVector()
    {
        return _vectors;

    }
    protected override IDrawer GetScheme()
    {
        return _scheme;

    }

}