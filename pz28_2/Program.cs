using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем автомобиль и патрульного
            var car = new Car();
            var patrol = new Patrol();

            // Подписываемся на события автомобиля
            car.SpeedChanged += (sender, speed) =>
            {
                if (speed > 80 && speed <= 120)
                {
                    patrol.Warn();
                }
                else if (speed > 120)
                {
                    patrol.Arrest();
                }
            };

            // Запускаем автомобиль
            car.Start();

            Console.ReadLine();
        }
    }

    class Car
    {
        private int _speed;
        private bool _started;

        public event EventHandler<int> SpeedChanged;

        public void Start()
        {
            if (!_started)
            {
                _started = true;
                Accelerate();
            }
        }

        private async void Accelerate()
        {
            for (int i = 0; i <= 200; i++)
            {
                _speed = i;
                SpeedChanged?.Invoke(this, i);
                await System.Threading.Tasks.Task.Delay(100);
                Console.WriteLine($"Скорость автомобиля: {_speed}");
            }
        }
    }

    class Patrol
    {
        public void Warn()
        {
            Console.WriteLine("Превышена скорость! Снизьте скорость до 80 км/ч");
        }

        public void Arrest()
        {
            Console.WriteLine("Превышена скорость! Активизирован режим задержания!");
        }
    }
}