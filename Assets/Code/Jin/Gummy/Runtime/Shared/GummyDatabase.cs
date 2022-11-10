using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Entries;
using System;

namespace Jin.Gummy.Shared
{
    public class GummyDatabase
    {
        public GummyBaseEntry CreateEntry(GummyCollection table, Type type)
        {
            // Will change
            return new GummyFactEntry();
        }
    }
}