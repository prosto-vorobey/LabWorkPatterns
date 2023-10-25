using System;
using System.Collections.Generic;

public class DischargedVector : IVector
{
    private Dictionary<int, int> _disVector;
    public int DimVector
    {
        get;

    }
    public DischargedVector (int dim)
    {
        DimVector = dim;
        _disVector = new Dictionary<int, int> ();

    }
    public void Set(int pos, int val)
    {
        try
        {
            if (pos > DimVector)
            {
                throw new IndexOutOfRangeException("Введённое положение выходит за границу вектора.");

            }
            if (val != 0)
            {
                _disVector.Add(pos, val);

            }

        }
        catch(IndexOutOfRangeException ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }
        catch (ArgumentException)
        {
            _disVector[pos] = val;

        }

    }
    public int Get(int pos)
    {
        int val = 0;
        if (_disVector.ContainsKey(pos))
        {
            val = _disVector[pos];

        }
        return val;

    }

}
