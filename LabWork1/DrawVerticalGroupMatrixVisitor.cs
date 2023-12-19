public class DrawVerticalGroupMatrixVisitor : ADrawMatrixVisitor
{
    private IDrawer _drawer;
    private IDrawMatrixVisitorElementStrategy _strategyElement;
    private IDrawCompositeMatrixVisitorStrategy _strategy;
    private int _shift = 0;
    public DrawVerticalGroupMatrixVisitor(IDrawer drawer)
    {
        _drawer = drawer;
        _strategy = new DrawShiftDownStrategy();

    }
    public override void VisitDrawDischargedMatrix(IMatrix dischargedMatrix)
    {
        _strategyElement = new DrawDischargedMatrixElementStrategy(this);
        _strategy.Draw(dischargedMatrix, _strategyElement, _shift);
        _shift += dischargedMatrix.NumColumns;
        //DrawBorder(dischargedMatrix.NumColumns, dischargedMatrix.NumRows, MatrixMaxVal.GetLenghtMaxVal(dischargedMatrix));

    }
    public override void VisitDrawOrdinaryMatrix(IMatrix ordinaryMatrix)
    {
        _strategyElement = new DrawOrdinaryMatrixElementStrategy(this);
        _strategy.Draw(ordinaryMatrix, _strategyElement, _shift);
        _shift += ordinaryMatrix.NumColumns;
        //DrawBorder(ordinaryMatrix.NumColumns, ordinaryMatrix.NumRows, MatrixMaxVal.GetLenghtMaxVal(ordinaryMatrix));

    }
    protected override IDrawer GetDrawer()
    {
        return _drawer;

    }

}
