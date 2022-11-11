using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Entries;
using Jin.Gummy.References;
using Jin.Gummy.Shared;
using System;

namespace Jin.Gummy.Tools
{
    public enum GummyEntryComparisonOperator : int
    {
        LESS_THAN,
        LESS_THAN_EQ,
        GREATER_THAN,
        GREATER_THAN_EQ,
        EQUALS_TO,
        NOT_EQUALS_TO,
        EXISTS,
    }

    [Serializable]
    public class GummyEntryCriteria : ScriptableObject
    {
        [SerializeField] public GummyEntryReference entry;
        [SerializeField] public GummyEntryComparisonOperator comparator = GummyEntryComparisonOperator.EQUALS_TO;
        public int rhs;

        public bool Test(IGummyDatabase database)
        {
            int entryValue = database.GetBlackboardForEntry(entry).Get(entry);
            switch(comparator)
            {
                case GummyEntryComparisonOperator.EQUALS_TO:
                    return entryValue == rhs;
                case GummyEntryComparisonOperator.NOT_EQUALS_TO:
                    return entryValue != rhs;
                case GummyEntryComparisonOperator.LESS_THAN:
                    return entryValue < rhs;
                case GummyEntryComparisonOperator.LESS_THAN_EQ:
                    return entryValue <= rhs;
                case GummyEntryComparisonOperator.GREATER_THAN:
                    return entryValue > rhs;
                case GummyEntryComparisonOperator.GREATER_THAN_EQ:
                    return entryValue >= rhs;
                default:
                    return false;
            }
            // ensures the conditions are ripe :)
        }
    }
}
