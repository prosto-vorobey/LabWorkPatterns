using System;

public class OrdinaryVector : IVector
{
    private int[] _ordVector;
    public int DimVector 
    {
        get;
    
    }
    public OrdinaryVector(int dim)
    {
        DimVector = dim;
        _ordVector = new int[DimVector];

    }
    public void Set (int pos, int val)
    {
        try
        {
            if (pos > DimVector)
            {
                throw new IndexOutOfRangeException("Введённое положение выходит за границу вектора.");

            }
            _ordVector[pos] = val;
            
        }
        catch(IndexOutOfRangeException ex)
        {
            MessageWarning.MessageOutRange(ex.Message);

        }

    }
    public int Get (int pos)
    {
        return _ordVector[pos];

    }

}
