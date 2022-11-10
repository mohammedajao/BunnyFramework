using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Attributes;
using Jin.Gummy.References;
using Jin.Gummy.Shared;

namespace Jin.Gummy.Entries
{
    [Serializable]
    public abstract class GummyBaseEntry
    {
        public int id;
        public string key;

        [GummyEntryFilter(Type = GummyEntryType.Fact, Base = typeof(GummyBaseEntry), AllowEmpty = true)]
        public GummyEntryReference scope;

        public bool once;

        public abstract void AddToTable(GummyCollection db);
        public abstract void RemoveFromTable(GummyCollection db);
    }
}