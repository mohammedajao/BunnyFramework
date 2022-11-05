using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Entries;

namespace Jin.Gummy.Shared
{
    [Serializable]
    public class GummyCollection : ScriptableObject
    {
        public string collectionName;
        // Later we'll have separate lists for facts, rules, & events
        [SerializeReference] public List<GummyBaseEntry> entries;

        public virtual void RemoveEntry(GummyBaseEntry entry)
        {
            // here we want the entry to remove from a table
        }

        public virtual void AddEntry(GummyBaseEntry entry)
        {
            // here we want the entry to add itself to a table
        }

        public virtual void Initialize()
        {
            
        }
    }
}