using System;

public class Running : Activity
{
	private double _distanceKm; // stored distance in km

	public Running(DateTime date, int minutes, double distanceKm) : base(date, minutes)
	{
		_distanceKm = distanceKm;
	}

	public override double GetDistanceKm() => _distanceKm;

	public override double GetSpeedKph()
	{
		return (_distanceKm / Minutes) * 60.0;
	}

	public override double GetPaceMinPerKm()
	{
		return Minutes / Math.Max(_distanceKm, 0.000001);
	}
}


