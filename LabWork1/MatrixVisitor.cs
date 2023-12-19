public interface IMatrixVisitor
{
    void VisitDrawDischargedMatrix (IMatrix dischargedMatrix);
    void VisitDrawOrdinaryMatrix (IMatrix ordinaryMatrix);

}
