public interface IDrawCompositeMatrixVisitorStrategy
{
    void Draw(IMatrix matrix, IDrawMatrixVisitorElementStrategy strategy, int shift);

}
public class DrawShiftRightStrategy : IDrawCompositeMatrixVisitorStrategy
{
    public void Draw(IMatrix matrix, IDrawMatrixVisitorElementStrategy strategy, int shift)
    {
        for (int i = 0; i < matrix.NumColumns; i++)
        {
            for (int j = 0; j < matrix.NumRows; j++)
            {
                int num = matrix.Get(i, j);
                strategy.Draw(i + shift, j, num, matrix);

            }

        }

    }

}

public class DrawShiftDownStrategy : IDrawCompositeMatrixVisitorStrategy
{
    public void Draw(IMatrix matrix, IDrawMatrixVisitorElementStrategy strategy, int shift)
    {
        for (int i = 0; i < matrix.NumColumns; i++)
        {
            for (int j = 0; j < matrix.NumRows; j++)
            {
                int num = matrix.Get(i, j);
                strategy.Draw(j, i + shift, num, matrix);

            }

        }

    }

}
