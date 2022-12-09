using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.References;
using Jin.Gummy.Attributes;
using Jin.Gummy.Entries;
using Jin.Gummy.Shared;

namespace Jin.Gummy.Blackboard
{
    public enum GummyFactOperation
    {
        SET,
        INCREMENT
    }

    public class GummyBlackboardModification
    {
        [GummyEntryFilter(Base = typeof(GummyBaseEntry))]
        public GummyEntryReference entry;

        public GummyFactOperation comparator = GummyFactOperation.SET;

        public int input;

        public void Execute(IGummyDatabase database)
        {
            IGummyBlackboard board = database.GetBlackboardForEntry(entry);
            if(comparator == GummyFactOperation.SET) {
                board.Set(entry, input);
            } else if(comparator == GummyFactOperation.INCREMENT) {
                board.Set(entry, board.Get(entry) + input);
            }
        }
    }
}