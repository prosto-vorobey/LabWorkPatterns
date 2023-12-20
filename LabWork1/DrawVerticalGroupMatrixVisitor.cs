public class DrawVerticalGroupMatrixVisitor : IMatrixVisitor
{
    private IDrawer _drawer;
    private IMatrixDraw _matrixDraw;
    private int _shift = 0;
    public DrawVerticalGroupMatrixVisitor(IDrawer drawer)
    {
        _drawer = drawer;

    }
    public void VisitDischargedMatrix(IMatrix dischargedMatrix)
    {
        _matrixDraw = new MatrixDrawShiftDownDecorator(new DischargedMatrixDraw(), _shift);
        _matrixDraw.Draw(dischargedMatrix, _drawer);
        _shift += dischargedMatrix.NumColumns;

    }
    public void VisitOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        _matrixDraw = new MatrixDrawShiftDownDecorator(new OrdinaryMatrixDraw(), _shift);
        _matrixDraw.Draw(ordinaryMatrix, _drawer);
        _shift += ordinaryMatrix.NumColumns;

    }

}
