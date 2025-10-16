using System;

public class Swimming : Activity
{
	private int _laps; // 1 lap = 50 meters

	public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
	{
		_laps = laps;
	}

	public override double GetDistanceKm()
	{
		return (_laps * 50.0) / 1000.0;
	}

	public override double GetSpeedKph()
	{
		double km = GetDistanceKm();
		return (km / Minutes) * 60.0;
	}

	public override double GetPaceMinPerKm()
	{
		double km = GetDistanceKm();
		return Minutes / Math.Max(km, 0.000001);
	}
}


