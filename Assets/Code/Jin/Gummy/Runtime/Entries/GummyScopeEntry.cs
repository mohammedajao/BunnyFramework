using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Jin.Gummy.Entries
{
    public enum GummyEntryScope
    {
        GLOBAL,
        AREA,
        SCENE,
        TEMPORARY
    }

    [Serializable]
    public class GummyScopeEntry
    {
        [SerializeField]
        public GummyEntryScope scope;
    }
}