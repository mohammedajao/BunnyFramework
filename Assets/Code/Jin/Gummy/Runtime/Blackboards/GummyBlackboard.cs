using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Entries;

namespace Jin.Gummy.Blackboard
{
    // youtube.com/watch?v=wj-2vbiyHnI
    // A blackboard is a map of KVP that takes in a fact and maps it to a value
    // In Gummy's case, events and rules are also treated as facts
    // Each blackboard is a type of context
    public interface IGummyBlackboard
    {
        int GetEntryValue(GummyBaseEntry entry);
        void SetEntryValue(GummyBaseEntry entry, int value);
    }

    public abstract class GummyBlackboard : IGummyBlackboard
    {
        private Dictionary<int, int> storage = new();
        public string Key;

        public int GetEntryValue(GummyBaseEntry entry)
        {
            return storage[entry.id];
        }

        public void UpdateEntry(GummyBaseEntry entry, int value)
        {
            storage[entry.id] = value;
        }
    }
}

