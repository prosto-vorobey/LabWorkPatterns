public class DrawLeafMatrixVisitor : ADrawMatrixVisitor
{
    private IDrawer _drawer;
    private IDrawMatrixVisitorElementStrategy _strategy;
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
                int num = dischargedMatrix.Get(i, j);
                _strategy.Draw(i, j, num, dischargedMatrix);

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
                int num = ordinaryMatrix.Get(i, j);
                _strategy.Draw(i, j, num, ordinaryMatrix);

            }

        }
        DrawBorder(ordinaryMatrix.NumColumns, ordinaryMatrix.NumRows, MatrixMaxVal.GetLenghtMaxVal(ordinaryMatrix));

    }
    protected override IDrawer GetDrawer()
    {
        return _drawer;

    }

}
