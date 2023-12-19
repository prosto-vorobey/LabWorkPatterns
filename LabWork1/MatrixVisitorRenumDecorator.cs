public class MatrixVisitorRenumDecorator : IMatrixVisitor
{
    private IMatrixVisitor _drawer;
    public MatrixVisitorRenumDecorator(IMatrixVisitor drawer)
    {
        _drawer = drawer;

    }
    public void VisitDischargedMatrix(IMatrix dischargedMatrix)
    {
        dischargedMatrix = new MatrixRenumDecorator(dischargedMatrix);
        _drawer.VisitDischargedMatrix(dischargedMatrix);

    }
    public void VisitOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        ordinaryMatrix = new MatrixRenumDecorator(ordinaryMatrix);
        _drawer.VisitOrdinaryMatrix(ordinaryMatrix);

    }

}