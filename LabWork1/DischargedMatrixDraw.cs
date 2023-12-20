public class DischargedMatrixDraw : IMatrixDraw
{
    IMatrixDrawElementStrategy _strategy;
    public DischargedMatrixDraw()
    {
        _strategy = new DischargedMatrixDrawElement();

    }
    public void Draw(IMatrix matrix, IDrawer drawer)
    {
        int maxLenght = MatrixMaxVal.GetLenghtMaxVal(matrix);
        for (int i = 0; i < matrix.NumColumns; i++)
        {
            for (int j = 0; j < matrix.NumRows; j++)
            {
                int num = matrix.Get(i, j);
                _strategy.Draw(i, j, num, maxLenght, drawer);

            }

        }
        drawer.DrawBorder(matrix.NumColumns, matrix.NumRows, maxLenght);

    }
    public IMatrixDrawElementStrategy GetStrategy()
    {
        return _strategy;

    }

    public class DischargedMatrixDrawElement : IMatrixDrawElementStrategy
    {
        public void Draw(int col, int row, int num, int maxLenght, IDrawer drawer)
        {
            drawer.DrawCellBorder(col, row, maxLenght);
            if (num == 0)
            {
                return;

            }
            drawer.DrawContent(num.ToString(), col, row, maxLenght);

        }

    }

}
