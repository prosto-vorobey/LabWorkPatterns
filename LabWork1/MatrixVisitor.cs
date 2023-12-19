public interface IMatrixVisitor
{
    void VisitDrawDischargedMatrix (IMatrix dischargedMatrix);
    void VisitDrawOrdinaryMatrix (IMatrix ordinaryMatrix);

}
public abstract class ADrawMatrixVisitor : IMatrixVisitor
{
    abstract public void VisitDrawDischargedMatrix(IMatrix dischargedMatrix);
    abstract public void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix);
    abstract protected IDrawer GetDrawer();
    protected void DrawContent(string cont, int col, int row, int maxValLength)
    {
        GetDrawer().DrawContent(cont, col, row, maxValLength);

    }
    protected void DrawCellBorder(int col, int row, int maxValLength)
    {
        GetDrawer().DrawCellBorder(col, row, maxValLength);

    }
    protected void DrawBorder(int numCols, int numRows, int maxValLength)
    {
        GetDrawer().DrawBorder(numCols, numRows, maxValLength);

    }
    public class DrawOrdinaryMatrixElementStrategy : IDrawMatrixVisitorStrategy
    {
        private ADrawMatrixVisitor _visitor;
        public DrawOrdinaryMatrixElementStrategy(ADrawMatrixVisitor visitor)
        {
            _visitor = visitor;

        }
        public void Draw(int col, int row, IMatrix matrix)
        {
            int maxLenght = MatrixMaxVal.GetLenghtMaxVal(matrix);
            int num = matrix.Get(col, row);
            _visitor.DrawCellBorder(col, row, maxLenght);
            _visitor.DrawContent(num.ToString(), col, row, maxLenght);

        }

    }
    public class DrawDischargedMatrixElementStrategy : IDrawMatrixVisitorStrategy
    {
        private ADrawMatrixVisitor _visitor;
        public DrawDischargedMatrixElementStrategy(ADrawMatrixVisitor visitor)
        {
            _visitor = visitor;

        }
        public void Draw(int col, int row, IMatrix matrix)
        {
            int maxLenght = MatrixMaxVal.GetLenghtMaxVal(matrix);
            int num = matrix.Get(col, row);
            _visitor.DrawCellBorder(col, row, maxLenght);
            if (num == 0)
            {
                return;

            }
            _visitor.DrawContent(num.ToString(), col, row, maxLenght);

        }

    }

}
