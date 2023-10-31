using System;

public class OrdinaryMatrix : AMatrix
{
    private OrdinaryVector[] _vectors;
    public OrdinaryMatrix(int cols, int rows)
    {
        NumColumns = cols;
        NumRows = rows;
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
    public override void Draw(IDrawerMatrix drawerMatrix)
    {
        base.Draw(drawerMatrix);
        for (int i = 0; i < NumColumns; i++)
        {
            for (int j = 0; j < NumRows; j++)
            {
                int num = Get(i, j);
                drawerMatrix.DrawContent(num.ToString(), i, j, GetLenghtMaxVal());

            }

        }

    }

}
