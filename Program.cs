using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main()
    {
        int[] notes = { 523, 528, 453, 698, 523, 528, 453, 698, 300, 523, 528, 453, 698, 693, 453, 500, 453, 523, 528, 453, 698, 693, 453, 500, 453 };
        int[] durations = { 900, 300, 500, 900, 900, 300, 500, 900, 300, 900, 300, 500, 900, 900, 400, 600, 400, 900, 300, 500, 900, 900, 400, 600, 400 };
        int[] sleepDurations = { 1, 1, 1, 1700, 1, 1, 1, 1700, 300, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1};

        PlayMelody(notes, durations, sleepDurations);
    }

    static void PlayMelody(int[] notes, int[] durations, int[] sleepDurations)
    {
        for (int i = 0; i < notes.Length; i++)
        {
            Console.Beep(notes[i], durations[i]);

            Thread.Sleep(sleepDurations[i]);
        }
    }
}