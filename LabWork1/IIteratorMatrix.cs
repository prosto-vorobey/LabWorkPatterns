using System.Collections.Generic;

public interface IMatrixIterator
{
    void Reset();
    IMatrix GetCurrent();
    void MoveNext();
    bool IsDone();

}
public class CompositeMatrixIterator : IMatrixIterator
{
    private ICompositeMatrix _matrix;
    int _current = 0;
    public CompositeMatrixIterator(ICompositeMatrix matrix)
    {
        _matrix = matrix;

    }
    public IMatrix GetCurrent()
    {
        return _matrix.GetMatrix(_current);

    }
    public bool IsDone()
    {
        if (_matrix.Count() == _current)
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
            _current++;

        }

    }
    public void Reset()
    {
        _current = 0;

    }

}