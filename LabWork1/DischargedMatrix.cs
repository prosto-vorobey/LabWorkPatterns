public class DischargedMatrix : AMatrix
{
    private IVector[] _vectors;
    public DischargedMatrix(int cols, int rows)
    {
        NumColumns = cols;
        NumRows = rows;
        _vectors = new DischargedVector[NumColumns];
        for (int i = 0; i < NumColumns; i++)
        {
            _vectors[i] = new DischargedVector(NumRows);

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
                drawerMatrix.DrawCellBorder(i, j, GetLenghtMaxVal());
                if (num == 0)
                {
                    continue;

                }
                drawerMatrix.DrawContent(num.ToString(), i, j, GetLenghtMaxVal());

            }

        }
        base.Draw(drawerMatrix);

    }

}