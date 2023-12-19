public interface ICompositeMatrix : IMatrix, IIterable
{
    void AddMatrix(IMatrix matrix);
    IMatrix GetMatrix(int current);
    int Count();

}