public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    // Distance in kilometers (each lap = 50 meters)
    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }

    // Speed = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    // Pace = minutes per km
    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}