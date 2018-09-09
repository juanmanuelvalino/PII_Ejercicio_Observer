using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureMonitor monitor = new TemperatureMonitor();
            TemperatureReporter reporter = new TemperatureReporter();
            monitor.Subscribe(reporter);
            monitor.GetTemperature();
        }
    }
}
