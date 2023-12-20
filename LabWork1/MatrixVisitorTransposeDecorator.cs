public class MatrixVisitorTransposeDecorator : IMatrixVisitor
{
    private IMatrixVisitor _drawer;
    public MatrixVisitorTransposeDecorator(IMatrixVisitor drawer)
    {
        _drawer = drawer;

    }
    public void VisitDischargedMatrix(IMatrix dischargedMatrix)
    {
        dischargedMatrix = new MatrixTransposeDecorator(dischargedMatrix);
        _drawer.VisitDischargedMatrix(dischargedMatrix);

    }
    public void VisitOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        ordinaryMatrix = new MatrixTransposeDecorator(ordinaryMatrix);
        _drawer.VisitOrdinaryMatrix(ordinaryMatrix);

    }

}