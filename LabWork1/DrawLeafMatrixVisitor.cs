public class DrawLeafMatrixVisitor : IMatrixVisitor
{
    private IDrawer _drawer;
    private IMatrixDraw _matrixDraw;
    public DrawLeafMatrixVisitor (IDrawer drawer)
    {
        _drawer = drawer;

    }
    public void VisitDrawDischargedMatrix(IMatrix dischargedMatrix)
    {
        _matrixDraw = new DischargedMatrixDraw();
        _matrixDraw.Draw(dischargedMatrix, _drawer);

    }
    public void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        _matrixDraw = new OrdinaryMatrixDraw();
        _matrixDraw.Draw(ordinaryMatrix, _drawer);

    }

}
