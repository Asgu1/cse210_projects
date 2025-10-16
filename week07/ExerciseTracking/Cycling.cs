using System;

public class Cycling : Activity
{
	private double _speedKph; // stored average speed

	public Cycling(DateTime date, int minutes, double speedKph) : base(date, minutes)
	{
		_speedKph = speedKph;
	}

	public override double GetDistanceKm()
	{
		return _speedKph * (Minutes / 60.0);
	}

	public override double GetSpeedKph()
	{
		return _speedKph;
	}

	public override double GetPaceMinPerKm()
	{
		return 60.0 / Math.Max(_speedKph, 0.000001);
	}
}


