public interface IMatrixVisitor
{
    void VisitDrawDischargedMatrix (IMatrix dischargedMatrix);
    void VisitDrawOrdinaryMatrix (IMatrix ordinaryMatrix);

}
public abstract class ADrawMatrixVisitor : IMatrixVisitor
{
    private IDrawer _drawer;
    abstract public void VisitDrawDischargedMatrix(IMatrix dischargedMatrix);
    abstract public void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix);
    abstract protected IDrawer GetDrawer();
    protected void DrawContent(string cont, int col, int row, int maxValLength)
    {
        _drawer = GetDrawer();
        _drawer.DrawContent(cont, col, row, maxValLength);

    }
    protected void DrawCellBorder(int col, int row, int maxValLength)
    {
        _drawer = GetDrawer();
        _drawer.DrawCellBorder(col, row, maxValLength);

    }
    protected void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        _drawer = GetDrawer();
        _drawer.DrawBorder(numCols, numRows, maxValLength);

    }
    public class DrawOrdinaryMatrixElementStrategy : IDrawMatrixVisitorElementStrategy
    {
        private ADrawMatrixVisitor _visitor;
        public DrawOrdinaryMatrixElementStrategy(ADrawMatrixVisitor visitor)
        {
            _visitor = visitor;

        }
        public void Draw(int col, int row, int num, IMatrix matrix)
        {
            int maxLenght = MatrixMaxVal.GetLenghtMaxVal(matrix);
            _visitor.DrawCellBorder(col, row, maxLenght);
            _visitor.DrawContent(num.ToString(), col, row, maxLenght);

        }

    }
    public class DrawDischargedMatrixElementStrategy : IDrawMatrixVisitorElementStrategy
    {
        private ADrawMatrixVisitor _visitor;
        public DrawDischargedMatrixElementStrategy(ADrawMatrixVisitor visitor)
        {
            _visitor = visitor;

        }
        public void Draw(int col, int row, int num, IMatrix matrix)
        {
            int maxLenght = MatrixMaxVal.GetLenghtMaxVal(matrix);
            _visitor.DrawCellBorder(col, row, maxLenght);
            if (num == 0)
            {
                return;

            }
            _visitor.DrawContent(num.ToString(), col, row, maxLenght);

        }

    }

}
