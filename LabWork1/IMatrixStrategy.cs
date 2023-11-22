public interface IMatrixStrategy
{
    void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix);
    IDrawMatrixStrategy GetDrawStrategy();

}