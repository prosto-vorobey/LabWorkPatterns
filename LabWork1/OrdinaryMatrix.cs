public class OrdinaryMatrix : AMatrix
{
    private IVector[] _vectors;
    public OrdinaryMatrix(int cols, int rows)
    {
        NumColumns = cols;
        NumRows = rows;
        _vectors = new OrdinaryVector[cols];
        for (int i = 0; i < cols; i++)
        {
            _vectors[i] = new OrdinaryVector(rows);

        }

    }
    public override void Accept(IMatrixVisitor drawer)
    {
        drawer.VisitDrawOrdinaryMatrix(this);

    }
    protected override IVector[] GetVector()
    {
       return _vectors;

    }

}
