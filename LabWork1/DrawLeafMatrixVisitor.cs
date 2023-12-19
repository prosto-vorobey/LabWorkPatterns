public class DrawLeafMatrixVisitor : ADrawMatrixVisitor
{
    private IDrawer _drawer;
    private IDrawMatrixVisitorStrategy _strategy;
    public DrawLeafMatrixVisitor (IDrawer drawer)
    {
        _drawer = drawer;

    }
    public override void VisitDrawDischargedMatrix(IMatrix dischargedMatrix)
    {
        for (int i = 0; i < dischargedMatrix.NumColumns; i++)
        {
            for (int j = 0; j < dischargedMatrix.NumRows; j++)
            {
                _strategy = new DrawDischargedMatrixElementStrategy(this);
                _strategy.Draw(i, j, dischargedMatrix);

            }

        }
        DrawBorder(dischargedMatrix.NumColumns, dischargedMatrix.NumRows, MatrixMaxVal.GetLenghtMaxVal(dischargedMatrix));

    }
    public override void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        for (int i = 0; i < ordinaryMatrix.NumColumns; i++)
        {
            for (int j = 0; j < ordinaryMatrix.NumRows; j++)
            {
                _strategy = new DrawOrdinaryMatrixElementStrategy(this);
                _strategy.Draw(i, j, ordinaryMatrix);

            }

        }
        DrawBorder(ordinaryMatrix.NumColumns, ordinaryMatrix.NumRows, MatrixMaxVal.GetLenghtMaxVal(ordinaryMatrix));

    }
    protected override IDrawer GetDrawer()
    {
        return _drawer;

    }

}
