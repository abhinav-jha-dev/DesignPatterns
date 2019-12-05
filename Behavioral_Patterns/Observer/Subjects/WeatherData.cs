using Observer.Observers;
using System.Collections.Generic;
using System.Linq;

namespace Observer.Subjects
{
    public class WeatherData : ISubject
    {
        private IList<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeatherData()
        {
            _observers = new List<IObserver>();
        }

        public void notifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.update(_temperature, _humidity, _pressure);
            }
        }

        public void registerObserver(IObserver o)
        {
            _observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
            {
                _observers.RemoveAt(i);
            }
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            measurementChanged();
        }

        private void measurementChanged()
        {
            notifyObserver();
        }

        // other WeatherData method here
    }
}