using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Attributes;

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
    }
}