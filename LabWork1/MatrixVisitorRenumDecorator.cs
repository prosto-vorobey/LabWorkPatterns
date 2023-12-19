public class MatrixVisitorRenumDecorator : IMatrixVisitor
{
    private IMatrixVisitor _drawer;
    public MatrixVisitorRenumDecorator(IMatrixVisitor drawer)
    {
        _drawer = drawer;

    }
    public void VisitDrawDischargedMatrix(IMatrix dischargedMatrix)
    {
        dischargedMatrix = new MatrixRenumDecorator(dischargedMatrix);
        _drawer.VisitDrawDischargedMatrix(dischargedMatrix);

    }
    public void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        ordinaryMatrix = new MatrixRenumDecorator(ordinaryMatrix);
        _drawer.VisitDrawOrdinaryMatrix(ordinaryMatrix);

    }

}