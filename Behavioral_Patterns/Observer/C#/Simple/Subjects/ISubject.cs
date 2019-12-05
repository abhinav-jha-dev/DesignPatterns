using Observer.Observers;

namespace Observer.Subjects
{
    interface ISubject
    {
        void registerObserver(IObserver o);
        void removeObserver(IObserver o);
        void notifyObserver();
    }
}