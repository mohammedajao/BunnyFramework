using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.References;
using Jin.Gummy.Attributes;
using Jin.Gummy.Entries;

namespace Jin.Gummy.Blackboard
{
    public class GummyBlackboardModification
    {
        [GummyEntryFilter(Base = typeof(GummyBaseEntry))]
        public GummyEntryReference entry;
    }
}