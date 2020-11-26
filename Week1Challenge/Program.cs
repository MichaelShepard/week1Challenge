using System;

namespace Week1Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            MethodLocation methodLocation = new MethodLocation();

            methodLocation.NameChallenge();

            methodLocation.CarTitles();

            methodLocation.TimeChallenge();

            methodLocation.AgeChallenge();

            DateTime goToSleepTime = new DateTime(2020, 11, 24, 20, 0, 0);
            DateTime awakeTime = new DateTime(2020, 11, 25, 8, 0, 0);
            methodLocation.AmountOfSleep(goToSleepTime, awakeTime);

            methodLocation.HowHasYourDayBeen();

            methodLocation.PrintCharactersInAString();

        }
    }
}
