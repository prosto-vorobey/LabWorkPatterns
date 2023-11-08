public interface IDrawerDisplay
{
    int GetIndex { get; }
    void Content (string cont, int corCellX, int corCellY);
    void Border (int corX1, int corY1, int corX2, int corY2);

}