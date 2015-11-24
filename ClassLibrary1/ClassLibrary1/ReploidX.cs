using System;
using ff14bot.AClasses;
using ff14bot.Managers;

namespace ReploidX
{

    public class ReploidX : BotPlugin
    {
        public override bool WantButton
        {
            get { return true; }
        }

        public override string ButtonText
        {
            get { return "Swap"; }
        }

        public override void OnButtonPress()
        {
            RoutineManager.PickRoutine();
        }

        public override string Author
        {
            get { return " DarkPietro"; }
        }

        public override Version Version
        {
            get { return new Version(0, 0, 1); }
        }

        public override string Name
        {
            get { return " ReploidX"; }
        }


    }

}