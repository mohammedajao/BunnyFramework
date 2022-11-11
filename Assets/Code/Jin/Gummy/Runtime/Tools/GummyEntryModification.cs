using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Blackboard;
using Jin.Gummy.References;
using Jin.Gummy.Shared;

namespace Jin.Gummy.Tools
{
    public enum GummyEntryModifierOperator
    {
        EQUALS_TO,
        ADD_BY,
        SUBTRACT_BY
    }

    public class GummyEntryModification
    {
        [SerializeField]
        public GummyEntryModifierOperator op;

        [SerializeField]
        public GummyEntryReference entry;

        public int value;

        public void Modify(IGummyDatabase database)
        {
            IGummyBlackboard blackboard = database.GetBlackboardForEntry(entry);
            int entryValue = blackboard.Get(entry);

            switch(op)
            {
                case GummyEntryModifierOperator.SUBTRACT_BY:
                    blackboard.Set(entry, entryValue - value);
                    break;
                case GummyEntryModifierOperator.ADD_BY:
                    blackboard.Set(entry, entryValue + value);
                    break;
                default:
                    blackboard.Set(entry, value);
                    break;
            }
        }
    }
}
