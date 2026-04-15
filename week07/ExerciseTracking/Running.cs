public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Distance is already stored
    public override double GetDistance()
    {
        return _distance;
    }

    // Speed = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    // Pace = minutes per distance unit
    public override double GetPace()
    {
        return GetMinutes() / _distance;
    }
}