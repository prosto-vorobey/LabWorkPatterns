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
