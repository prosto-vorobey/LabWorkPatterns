public interface IMatrixStrategy
{
    IVector[] GetMatrixVector(int cols, int rows);
    void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix);

}
public abstract class AMatrixStrategy : IMatrixStrategy
{
    public virtual void Draw (IMatrix matrix, IDrawerMatrix drawerMatrix)
    {
        drawerMatrix.DrawBorder(matrix.NumColumns, matrix.NumRows, GetLenghtMaxVal(matrix));

    }
    public abstract IVector[] GetMatrixVector(int cols, int rows);
    protected int GetLenghtMaxVal(IMatrix matrix)
    {
        int valMax = new MatrixStatistic(matrix).ValMax;
        int maxValLenght = NumLenght.GetLenght(valMax);
        return maxValLenght;

    }

}