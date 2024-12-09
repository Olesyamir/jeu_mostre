using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace BasicMonoGame;

public class Timer
{
    int TimeToDelay;
    int TimeElapsed;
    public bool IsTimerDone;

    public void StartTimer(GameTime gt, int AmountOfTime)
    {
        while (AmountOfTime < TimeElapsed)
        {
            IsTimerDone = false;
            TimeToDelay = AmountOfTime;
            if (IsTimerDone == false)
            {
                if (TimeToDelay == gt.ElapsedGameTime.TotalSeconds)
                {
                    IsTimerDone = true;

                }
                else TimeElapsed += 1;
            }
        }
    }
}
