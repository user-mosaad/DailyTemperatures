using System.Runtime.InteropServices.Marshalling;
using System.Text;

public readonly record struct DailyTemperature(double HighTemp, double LowTemp)
{
    public double Mean => (HighTemp + LowTemp) / 2.0;
}
