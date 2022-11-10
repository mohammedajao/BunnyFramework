using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Shared;

namespace Jin.Gummy.Entries
{
    public class GummyFactEntry : GummyBaseEntry
    {
        // Later, we can check if we want to move this to a descriptor class or attribute
        public override void AddToTable(GummyCollection db)
        {
            db.facts.Add(this);
        }

        public override void RemoveFromTable(GummyCollection db)
        {
            db.facts.Remove(this);
        }
    }
}
