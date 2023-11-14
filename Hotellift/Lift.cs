using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotellift
{
    internal class Lift
    {
        string usageTime;
        int cardID;
        int startingID;
        int endID;

        public Lift(string usageTime, int cardID, int startingID, int endID)
        {
            this.usageTime = usageTime;
            this.cardID = cardID;
            this.startingID = startingID;
            this.endID = endID;
        }

        public string UsageTime { get => usageTime; }
        public int CardID { get => cardID;}
        public int StartingID { get => startingID;}
        public int EndID { get => endID;}
    }
}
