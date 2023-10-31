using System;

public class SymmetryMatrix : AMatrix
{
    private IDrawerMatrix _scheme;
    private OrdinaryVector[] _vectors;
    public SymmetryMatrix(int numDim, IDrawerMatrix scheme = null)
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
    public override void DrawWithoutBorder()
    {
        int maxValLenght = GetLenghtMaxVal();
        DrawContect(maxValLenght);

    }
    public override void DrawWithBorder()
    {
        int maxValLenght = GetLenghtMaxVal();
        Border(_scheme, maxValLenght);
        DrawContect(maxValLenght);

    }
    public override void DrawWithDoubleBorder()
    {
        int maxValLenght = GetLenghtMaxVal();
        DoubleBorder(_scheme, maxValLenght);
        DrawContect(maxValLenght);

    }
    private void DrawContect(int maxValLenght)
    {
        for (int i = 0; i < NumColumns; i++)
        {
            for (int j = 0; j < NumRows; j++)
            {
                int num = Get(i, j);
                Content(_scheme, num.ToString(), i, j, maxValLenght);

            }

        }

    }

}
