using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Attributes;
using Jin.Gummy.Blackboard;
using Jin.Gummy.Shared;
using Jin.Gummy.References;
using Jin.Gummy.Tools;
using System;

namespace Jin.Gummy.Entries
{
    public class GummyRuleEntry : GummyBaseEntry, IComparable<GummyRuleEntry>
    {

        [SerializeField] public bool isCancellable;
        [SerializeField] private int padding;
        [SerializeField] private float delay;

        public GummyEntryReference triggeredBy;

        [GummyEntryFilter(AllowEmpty = true)]
        public GummyEntryReference triggers;

        [SerializeField]
        internal GummyEvent.Dispatcher[] onStart = Array.Empty<GummyEvent.Dispatcher>();

        [SerializeField]
        internal GummyEvent.Dispatcher[] onEnd = Array.Empty<GummyEvent.Dispatcher>();

        public int Weight => criteria.Length + padding;

        public float Delay => delay;

        [SerializeField]
        internal GummyBlackboardCriterion[] criteria = Array.Empty<GummyBlackboardCriterion>();

        [SerializeField]
        internal GummyBlackboardModification[] modifications = Array.Empty<GummyBlackboardModification>();

        public override void AddToTable(GummyCollection db)
        {
            db.rules.Add(this);
        }

        public override void RemoveFromTable(GummyCollection db)
        {
            db.rules.Remove(this);
        }

        public int CompareTo(GummyRuleEntry entry)
        {
            // Change later
            return 0;
        }
    }
}