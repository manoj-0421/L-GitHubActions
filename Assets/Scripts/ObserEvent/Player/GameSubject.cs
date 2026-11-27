using System.Collections.Generic;

public class GameSubject
{
    List<IObserver> observer = new List<IObserver>();

    public void Register(IObserver _obj)
    {
        if(observer.Contains(_obj) is false)
        {
            observer.Add(_obj);
        }
    }
    public void UnRegister(IObserver _obj)
    {
        if(observer.Contains(_obj))
        {
            observer.Remove(_obj);
        }
    }

    public void Notify()
    {
        foreach(var obj in observer)
        {
            obj.Notify();
        }
    }
}
