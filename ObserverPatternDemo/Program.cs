using ObserverPatternDemo.Observables.Implementations;
using ObserverPatternDemo.Observables.Interfaces;
using ObserverPatternDemo.Observers.Implementations;
using ObserverPatternDemo.Observers.Interfaces;
using System;
using System.Threading;

namespace ObserverPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IObservable chatRoom = new ConcreteObservable();
            IObserver person1 = new ConcreteObserver((ConcreteObservable)chatRoom);
            chatRoom.RegisterObserver(person1);

            while (true)
            {
                chatRoom.Notfy();
                Thread.Sleep(1000);
            }
        }
    }
}
 