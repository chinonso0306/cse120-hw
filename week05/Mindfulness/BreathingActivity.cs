using System;
using System.Collections.Generic;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing", "This activity helps you relax by guiding your breathing.")
    {
    }

    public void Run()
    {
        StartMessage();

        int time = 0;

        while (time + 6 <= _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            time += 3;

            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
            time += 3;
        }

        EndMessage();
    }
}