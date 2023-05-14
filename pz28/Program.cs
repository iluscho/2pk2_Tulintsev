using System;
using System.Threading;

class TemperatureSensor
{
    public event EventHandler<int> TemperatureChanged;

    public void CheckTemperature(int temperature)
    {
        if (temperature == -25 || temperature == 0 || temperature == 25 || temperature == 35)
            OnTemperatureChanged(temperature);
    }

    protected virtual void OnTemperatureChanged(int temperature)
    {
        TemperatureChanged?.Invoke(this, temperature);
    }
}

class TemperatureController
{
    private int _temperature = -30;
    private readonly TemperatureSensor _sensor = new TemperatureSensor();

    public TemperatureController()
    {
        _sensor.TemperatureChanged += (sender, temperature) =>
        {
            Console.WriteLine($"Температура достига отметки в {temperature} градусов!");
        };
    }

    public void Start()
    {
        while (_temperature <= 40)
        {
            _temperature++;
            Console.WriteLine($"Температура в реальном времени: {_temperature} градусов");
            _sensor.CheckTemperature(_temperature);
            Thread.Sleep(1000); // Задержка в 1 секунду
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var controller = new TemperatureController();
        controller.Start();
    }
}
