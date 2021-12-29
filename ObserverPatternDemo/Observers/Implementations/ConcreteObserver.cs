using ObserverPatternDemo.Observables.Implementations;
using ObserverPatternDemo.Observables.Interfaces;
using ObserverPatternDemo.Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternDemo.Observers.Implementations
{
    class ConcreteObserver : IObserver
    {
        ConcreteObservable _observable;
        public ConcreteObserver(ConcreteObservable observable)
        {
            _observable = observable;
            _observable.RegisterObserver(this);
        }
        public void Update()
        {
            Console.WriteLine($"Recieved Updates on { DateTime.Now }");
            Console.WriteLine($"Data: { _observable.GetState() }");
        }
    }
}
