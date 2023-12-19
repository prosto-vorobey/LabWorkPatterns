public class DischargedMatrix : AMatrix
{
    private IVector[] _vectors;
    public DischargedMatrix(int cols, int rows)
    {
        NumColumns = cols;
        NumRows = rows;
        _vectors = new DischargedVector[cols];
        for (int i = 0; i < cols; i++)
        {
            _vectors[i] = new DischargedVector(rows);

        }

    }
    public override void Accept(IMatrixVisitor drawer)
    {
        drawer.VisitDrawDischargedMatrix(this);

    }
    protected override IVector[] GetVector()
    {
        return _vectors;

    }

}