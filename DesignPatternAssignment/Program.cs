
// Observer interface
public interface IObserver
{
    void Update(float temperature);
}

// Subject interface
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}

// WeatherStation class (Subject)
public class WeatherStation : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private float temperature;

    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(temperature);
        }
    }

    public void SetTemperature(float temp)
    {
        temperature = temp;
        NotifyObservers();
    }
}

// WeatherDisplay class (Observer)
public class WeatherDisplay : IObserver
{
    private string name;

    public WeatherDisplay(string name)
    {
        this.name = name;
    }

    public void Update(float temperature)
    {
        Console.WriteLine($"{name} received temperature : {temperature}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {

        WeatherStation station = new WeatherStation();
        WeatherDisplay display1 = new WeatherDisplay("Display 1");
        WeatherDisplay display2 = new WeatherDisplay("Display 2");

        station.RegisterObserver(display1);
        station.RegisterObserver(display2);

        station.SetTemperature(20.5f);

        station.RemoveObserver(display1);

        station.SetTemperature(20.0f);
    }

}