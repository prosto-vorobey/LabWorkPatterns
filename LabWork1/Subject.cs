using System.Collections.Generic;
using System.Windows.Documents;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    //void Notify();

}
public class MatrixStatisticSubject : ISubject
{
    MatrixStatistic _state;
    private List<IObserver> _observers;
    public MatrixStatisticSubject (IMatrix matrix)
    {
        _observers = new List<IObserver>();
        _state = new MatrixStatistic(matrix);

    }
    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
        Notify();

    }
    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);

    }
    private void Notify()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(_state);

        }

    }
    public void ModifyState(IMatrix matrix)
    {
        _state = new MatrixStatistic(matrix);
        Notify();

    }

}