public class CompositeMatrix : AMatrixStrategy
{
    public override void Draw(IMatrix matrix, IDrawerMatrix drawerMatrix)
    {
        base.Draw(matrix, drawerMatrix);

    }

    public override IVector[] GetMatrixVector(int cols, int rows)
    {
        throw new System.NotImplementedException();

    }

}