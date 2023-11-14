public class DischargedMatrix : AMatrixStrategy
{
    private DischargedVector[] _vectors;
    public override IVector[] GetMatrixVector(int cols, int rows)
    {
        _vectors = new DischargedVector[cols];
        for (int i = 0; i < cols; i++)
        {
            _vectors[i] = new DischargedVector(rows);

        }
        return _vectors;

    }
    public override void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix)
    {
        for (int i = 0; i < matrix.NumColumns; i++)
        {
            for (int j = 0; j < matrix.NumRows; j++)
            {
                int num = matrix.Get(i, j);
                drawerMatrix.DrawCellBorder(i, j, GetLenghtMaxVal(matrix));
                if (num == 0)
                {
                    continue;

                }
                drawerMatrix.DrawContent(num.ToString(), i, j, GetLenghtMaxVal(matrix));

            }

        }
        base.Draw(matrix, drawerMatrix);

    }

}