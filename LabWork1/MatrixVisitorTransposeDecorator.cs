public class MatrixVisitorTransposeDecorator : IMatrixVisitor
{
    private IMatrixVisitor _drawer;
    public MatrixVisitorTransposeDecorator(IMatrixVisitor drawer)
    {
        _drawer = drawer;

    }
    public void VisitDrawDischargedMatrix(IMatrix dischargedMatrix)
    {
        dischargedMatrix = new MatrixTransposeDecorator(dischargedMatrix);
        _drawer.VisitDrawDischargedMatrix(dischargedMatrix);

    }
    public void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        ordinaryMatrix = new MatrixTransposeDecorator(ordinaryMatrix);
        _drawer.VisitDrawOrdinaryMatrix(ordinaryMatrix);

    }

}