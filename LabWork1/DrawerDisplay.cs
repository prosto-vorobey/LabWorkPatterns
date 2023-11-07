public interface IDrawerDisplay
{
    int GetIndex { get; }
    void Content(string cont, int corCellX, int corCellY);
    void Border(int width, int height);

}