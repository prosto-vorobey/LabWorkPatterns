using System;

public class OrdinaryMatrix : AMatrix
{
    private IDrawer _scheme;
    private OrdinaryVector[] _vectors;
    public OrdinaryMatrix(int cols, int rows, IDrawer scheme = null)
    {
        NumColumns = cols;
        NumRows = rows;
        _scheme = scheme;
        _vectors = new OrdinaryVector[NumColumns];
        for (int i = 0; i < NumColumns; i++)
        {
            _vectors[i] = new OrdinaryVector(NumRows);

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
