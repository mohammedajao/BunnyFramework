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

    // Won't use but saving for ref for object pooling: https://forum.unity.com/threads/how-to-use-a-data-blackboard.892612/
    public interface IGummyBlackboard
    {
        int Get(int identifier);
        void Set(int identifier, int value);
    }

    public abstract class GummyBlackboard : IGummyBlackboard
    {
        // Maybe look into a serializable dictionary and turning this into a ScriptableObject
        // Avoid strings for keys due to garbage collection. We may call several events per frame to access the blackboard
        private Dictionary<int, int> storage = new();
        public string Name;

        // Caller needs to also specify out for the 2nd argument
        public bool TryGet(int identifier, out int value, int defaultValue = 0)
        {
            if(storage.ContainsKey(identifier))
            {
                value = storage[identifier];
                return true;
            }
            value = defaultValue;
            return false;
        }

        public int Get(int identifier)
        {
            if(!storage.ContainsKey(identifier))
                return 0; // Entry doesn't exist
            return storage[identifier];
        }

        public void Set(int identifier, int value)
        {
            storage[identifier] = value;
        }

        public void Clear()
        {
            storage.Clear();
        }
    }
}

