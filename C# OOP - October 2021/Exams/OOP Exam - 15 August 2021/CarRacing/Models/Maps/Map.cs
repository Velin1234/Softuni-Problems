using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (racerOne.IsAvailable() && racerTwo.IsAvailable())
            {
                racerOne.Race();
                racerTwo.Race();
                double chanceOfwinningP1 = racerOne.Car.HorsePower * racerOne.DrivingExperience;
                double chanceOfwinningP2 = racerTwo.Car.HorsePower * racerTwo.DrivingExperience;
                chanceOfwinningP1 *= racerOne.RacingBehavior == "strict" ? 1.2 : 1.1;
                chanceOfwinningP2 *= racerTwo.RacingBehavior == "strict" ? 1.2 : 1.1;
                return string.Format(OutputMessages.RacerWinsRace, racerOne.Username, racerTwo.Username, chanceOfwinningP1 > chanceOfwinningP2 ? racerOne.Username : racerTwo.Username);
            }
            else if (racerOne.IsAvailable() == false && racerTwo.IsAvailable())
            {
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerTwo.Username, racerOne.Username);
            }
            else if (racerTwo.IsAvailable() == false && racerOne.IsAvailable())
            {
                return string.Format(OutputMessages.OneRacerIsNotAvailable, racerOne.Username, racerTwo.Username);
            }
            else
            {
                return OutputMessages.RaceCannotBeCompleted;
            }
        }
    }
}
