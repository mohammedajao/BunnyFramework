using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Tools;
using Jin.Gummy.Shared;

namespace Jin.Gummy.Entries
{
    public class GummyEventEntry : GummyBaseEntry
    {
        public override void AddToTable(GummyCollection db)
        {
            db.events.Add(this);
        }

        public override void RemoveFromTable(GummyCollection db)
        {
            db.events.Remove(this);
        }
    }

}