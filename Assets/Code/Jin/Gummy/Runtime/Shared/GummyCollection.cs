using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Entries;

namespace Jin.Gummy.Shared
{
    // A GummyDatabase Table
    [Serializable]
    public class GummyCollection : ScriptableObject
    {
        public string collectionName;
        [SerializeReference] public List<GummyFactEntry> facts;
        [SerializeReference] public List<GummyEventEntry> events;
        [SerializeReference] public List<GummyRuleEntry> rules;

        public virtual void RemoveEntry(GummyBaseEntry entry)
        {
            // here we want the entry to remove from a table
            entry.RemoveFromTable(this);
        }

        public virtual void AddEntry(GummyBaseEntry entry)
        {
            // here we want the entry to add itself to a table
            entry.AddToTable(this);
        }

        public virtual void Initialize(GummyDatabase database)
        {
        }
    }
}