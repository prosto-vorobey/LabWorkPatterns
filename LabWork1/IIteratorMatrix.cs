using System.Collections.Generic;

public interface IIteratorMatrix
{
    void Reset();
    IMatrix GetCurrent();
    void MoveNext();
    bool IsDone();

}
public class CompositeMatrixIterator : IIteratorMatrix
{
    private List<IMatrix> _matrixes;
    int current = 0;
    public CompositeMatrixIterator(List<IMatrix> matrixes)
    {
        _matrixes = matrixes;

    }
    public IMatrix GetCurrent()
    {
        return _matrixes[current];

    }
    public bool IsDone()
    {
        if (_matrixes.Count == current)
        {
            return true;

        }
        else
        {
            return false;

        }

    }
    public void MoveNext()
    {
        if (!IsDone())
        {
            current++;

        }

    }
    public void Reset()
    {
        current = 0;

    }

}