using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Entries;
using System;

namespace Jin.Editor
{
    public abstract class EntryDescriptor
    {
        public Type RealType { get; internal set; }

        public virtual String Name => RealType.Name;

        public virtual GummyEntryType Type { get; protected set; } = GummyEntryType.Rule;

        public virtual bool Optional { get; protected set; }
        // Criteria, Modifications, etc. panel
        public virtual bool HasCustomization => true;

        // Prev, Branches, Next panel
        public virtual bool HasNavigation => true;

        // current is the index of the current select option
        // ids & names list are the ids & names of the branches
        public virtual void CreateNextMenu(GummyBaseEntry entry, List<string> names, List<int> ids, ref int current)
        {
        }

        // Branches menu
        public virtual void CreateAlternativeMenu(GummyBaseEntry entry, List<string> names, List<int> ids, ref int current)
        {
        }

        public virtual void CreatePreviousMenu(GummyBaseEntry entry, List<string> names, List<int> ids, ref int current)
        {
        }
    }
}
