using System;
using System.Windows;

public interface IObserver
{
    void Update(Object obj);

}

public class MatrixStatisticObserver : IObserver, IMatrix
{
    private MatrixStatistic _state;
    private IVector[] _vectors;
    public int NumColumns { get; }
    public int NumRows { get; }
    public MatrixStatisticObserver()
    {
        NumColumns = 6;
        NumRows = 1;
        _vectors = new OrdinaryVector[NumColumns];
        for (int i = 0; i < NumColumns; i++)
        {
            _vectors[i] = new OrdinaryVector(NumRows);

        }

    }
    public void Update(Object obj)
    {
        _state = (MatrixStatistic)obj;
        Set(0, 0, _state.ValSumm);
        Set(1, 0, (int)_state.ValAver);
        Set(2, 0, _state.ValMax);
        Set(3, 0, _state.ValNotNull);
        Set(4, 0, _state.NumColumns);
        Set(5, 0, _state.NumRows);

    }
    public int Get(int col, int row)
    {
        return _vectors[col].Get(row);

    }
    public void Set(int col, int row, int val)
    {
        _vectors[col].Set(row, val);

    }
    public void Accept(IMatrixVisitor visitor)
    {
        visitor.VisitOrdinaryMatrix(this);

    }
    public ICompositeMatrix GetComposite()
    {
        return null;

    }
    public IMatrix GetComponent()
    {
        return this;

    }

}