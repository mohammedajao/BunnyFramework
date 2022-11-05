using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// We'll be using a sortedList. The keys are the rule entries 

public class BunnySortedRuleList : IEnumerable<BunnyRuleEntry>
{
    public List<BunnyRuleEntry> entries = new List<BunnyRuleEntry>();

    public IEnumerator<BunnyRuleEntry> GetEnumerator() {
        foreach(var item in entries)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
    
    public void Add(BunnyRuleEntry entry)
    {
        entries.Add(entry);
        entries.Sort((x, y) => y.criterion.Count.CompareTo(x.criterion.Count));
    }

    public void Remove(BunnyRuleEntry entry)
    {
        entries.Remove(entry);
        entries.Sort((x, y) => y.criterion.Count.CompareTo(x.criterion.Count));
    }
}
