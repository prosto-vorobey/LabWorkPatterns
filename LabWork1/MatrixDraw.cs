public interface IMatrixDraw
{
    void Draw(IMatrix matrix, IDrawer drawer);
    IMatrixDrawElementStrategy GetStrategy();

}