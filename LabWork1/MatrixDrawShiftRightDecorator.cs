public class MatrixDrawShiftRightDecorator : IMatrixDraw
{
    IMatrixDraw _matrixDraw;
    int _shift;
    public MatrixDrawShiftRightDecorator (IMatrixDraw matrixDraw, int shift)
    {
        _matrixDraw = matrixDraw;
        _shift = shift;

    }
    public void Draw(IMatrix matrix, IDrawer drawer)
    {
        IMatrixDrawElementStrategy strategy = GetStrategy();
        int maxLenght = MatrixMaxVal.GetLenghtMaxVal(matrix);
        for (int i = 0; i < matrix.NumColumns; i++)
        {
            for (int j = 0; j < matrix.NumRows; j++)
            {
                int num = matrix.Get(i, j);
                strategy.Draw(i + _shift, j, num, maxLenght, drawer);

            }

        }

    }
    public IMatrixDrawElementStrategy GetStrategy()
    {
        return _matrixDraw.GetStrategy();

    }

}