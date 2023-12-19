public class DrawHorizontalGroupMatrixVisitor : IMatrixVisitor
{
    private IDrawer _drawer;
    private IMatrixDraw _matrixDraw;
    private int _shift = 0;
    public DrawHorizontalGroupMatrixVisitor(IDrawer drawer)
    {
        _drawer = drawer;

    }
    public void VisitDrawDischargedMatrix(IMatrix dischargedMatrix)
    {
        _matrixDraw = new MatrixDrawShiftRightDecorator (new DischargedMatrixDraw(), _shift);
        _matrixDraw.Draw(dischargedMatrix, _drawer);
        _shift += dischargedMatrix.NumColumns;

    }
    public void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        _matrixDraw = new MatrixDrawShiftRightDecorator(new OrdinaryMatrixDraw(), _shift);
        _matrixDraw.Draw(ordinaryMatrix, _drawer);
        _shift += ordinaryMatrix.NumColumns;

    }

}
