using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.References;
using System;

namespace Jin.Gummy.Tools
{
    [Serializable]
    public class GummyEntryCriteria
    {
        [SerializeField] public GummyEntryReference entry;

        public bool Test()
        {
            // ensures the conditions are ripe :)
            return false;
        }
    }
}
