public interface IMatrixVisitor
{
    void VisitDischargedMatrix (IMatrix dischargedMatrix);
    void VisitOrdinaryMatrix (IMatrix ordinaryMatrix);

}
