using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Blackboard;
using Jin.Gummy.Entries;
using System;

namespace Jin.Gummy.Shared
{
    public class GummyDatabase
    {
        public GummyBaseEntry CreateEntry(GummyCollection table, Type type)
        {
            // Will change
            // perhaps this should create the entry ID
            return new GummyFactEntry();
        }

        // I'll probably have a map directly to a blackboard from the fact based on the current scene?
        // Then return a blackboard which requires the fact as an argument again to get the value assigned to the fact
    }
}