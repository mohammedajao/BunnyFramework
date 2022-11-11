using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Jin.Gummy.Blackboard;
using Jin.Gummy.Entries;
using System;

namespace Jin.Gummy.Shared
{

    public interface IGummyDatabase
    {
        IGummyBlackboard GetBlackboardForEntry(int fact);
        // Assign an entry to a blackboard
        void ApplyEntry(GummyBaseEntry entry, IGummyBlackboard context);
        GummyBaseEntry CreateEntry(GummyCollection table, Type type);
        // Use below to attempt to fetch an entry and assign to a variable
        // Since our blackboards are based on fact scope, we check the entry's scope for the blackboard
        // We have global, area, scene, and temporary scopes.
        bool TryGetEntry(int id, out GummyBaseEntry candidate);
        bool TryGetRule(int id, IGummyBlackboard context, out GummyRuleEntry match);
        bool TryGetTable(int id, out GummyCollection table);
        bool TestEntry(GummyBaseEntry entry, IGummyBlackboard context);
        IGummyBlackboard GetBlackboard(int scope, IGummyBlackboard context);
        void CreateLookupIfNecessary();
    }

    public class GummyDatabase
    {
        // Lookup Tables Dictionary<TKey,TValue>
        // Event Lookup
        // Rule Lookup
        // Fact Lookup

        private static int uid = Int32.MinValue;

        public GummyBaseEntry CreateEntry(GummyCollection table, Type type)
        {
            // Will change
            // perhaps this should create the entry ID
            int nuid = uid + 1;
            if (nuid == 0)
            {
                nuid += 1;
            }
            uid = nuid;
            return new GummyFactEntry();
        }

        // I'll probably have a map directly to a blackboard from the fact based on the current scene?
        // Then return a blackboard which requires the fact as an argument again to get the value assigned to the fact
    }
}