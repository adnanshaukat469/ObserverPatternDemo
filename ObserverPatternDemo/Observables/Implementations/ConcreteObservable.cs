using ObserverPatternDemo.Observables.Interfaces;
using ObserverPatternDemo.Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo.Observables.Implementations
{
    class ConcreteObservable : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnRegisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void Notfy()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public string GetState()
        {
            return DateTime.Now.ToString();
        }
    }
}
