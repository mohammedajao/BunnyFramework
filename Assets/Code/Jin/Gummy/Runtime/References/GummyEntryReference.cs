using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Entries;

namespace Jin.Gummy.References
{
    [Serializable]
    public class GummyEntryReference
    {
        public GummyBaseEntry entry;

        // public static implicit operator GummyEntryReference(int value)
        // {
        //     return new GummyEntryReference { ID = value };
        // }

        public static implicit operator int(GummyEntryReference value)
        {
            return value.entry.id;
        }

        public bool HasValue
        {
            get 
            {
                return entry != null;
            }
        }
    }
}