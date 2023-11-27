public interface IMatrixDrawStrategy
{
    void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix);
    IMatrixDrawElementStrategy GetDrawElementStrategy();

}