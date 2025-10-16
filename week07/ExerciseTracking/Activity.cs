using System;

public abstract class Activity
{
	private DateTime _date; // activity date
	private int _minutes; // duration in minutes

	protected Activity(DateTime date, int minutes)
	{
		_date = date;
		_minutes = minutes;
	}

	public DateTime Date => _date;
	public int Minutes => _minutes;

	// Metrics (km based)
	public abstract double GetDistanceKm();
	public abstract double GetSpeedKph();
	public abstract double GetPaceMinPerKm();

	public virtual string GetSummary()
	{
		// Example: 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
		return $"{Date:dd MMM yyyy} {GetType().Name} ({Minutes} min): Distance {GetDistanceKm():0.##} km, Speed: {GetSpeedKph():0.##} kph, Pace: {GetPaceMinPerKm():0.##} min per km";
	}
}


