using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.References;
using System;

namespace Jin.Gummy.Blackboard
{
    // https://blog.hekaton.studio/the-solution-for-systemic-game-management-the-blackboard-part-1/
    // https://blog.hekaton.studio/making-it-work-the-blackboard-part-2/
    // https://blog.hekaton.studio/making-it-remember-the-blackboard-part-3/

    // Row is mainly used for state saving due to Unity serialization
    // Maybe I should think more about this class
    public abstract class BlackboardRow : ScriptableObject
    {
        public GummyEntryReference entry; // We get the persistence type from the fact scope property
        public int Value;
        public abstract void SetSnapshotState();
        public abstract void ReverseSnapshot();
    }
}