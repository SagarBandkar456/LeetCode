using System;
using System.Collections.Generic;

class Program
{
    public static double AngleClock(int hour, int minutes)
    {
        float h = (hour % 12 + (float)minutes / 60) * 30;
        float m = minutes * 6;

        float angle = Math.Abs(h - m);
        if (angle > 180) angle = 360 - angle;

        return angle;
    }
    public static void Main(string[] args)
    {
        int hour = 12;
        int minutes = 30;
        Console.WriteLine(AngleClock(hour, minutes));
    }
}