using ObserverPatternDemo.Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo.Observables.Interfaces
{
    interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void UnRegisterObserver(IObserver observer);
        void Notfy();
    }
}
