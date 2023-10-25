public interface IDrawer
{
    void Content(string cont, int col, int row, int maxValLength);//Разобраться
    void Border(int numCols, int numRows, int maxValLength);
    void DoubleBorder(int numCol, int numRows, int maxValLength);

}