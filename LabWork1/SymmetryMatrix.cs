using System;

public class SymmetryMatrix : AMatrix
{
    private IDrawer _scheme;
    private OrdinaryVector[] _vectors;
    public SymmetryMatrix(int numDim, IDrawer scheme = null)
    {
        NumColumns = numDim;
        NumRows = numDim;
        _scheme = scheme;
        _vectors = new OrdinaryVector[NumColumns];
        for (int i = 0; i < NumColumns; i++)
        {
            _vectors[i] = new OrdinaryVector(NumRows);

        }

    }
    public override void Set(int col, int row, int val)
    {
        base.Set(col, row, val);
        base.Set(row, col, val);

    }
    protected override IVector[] GetMatrixVector()
    {
        return _vectors;

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
    protected override IDrawer GetScheme()
    {
        return _scheme;

    }

}
