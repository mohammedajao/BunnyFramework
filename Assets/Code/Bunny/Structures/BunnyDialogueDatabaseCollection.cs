using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "BDS/Data/FactCollection")]
public class BunnyDialogueDatabaseCollection : ScriptableObject
{
    [SerializeField]
    public string Name;

    public Dictionary<string, BunnyEventEntry> Events;
    public Dictionary<string, BunnyFactEntry> Facts;
    public Dictionary<string, BunnyRuleEntry> Rules;

    [SerializeField]
    public List<BunnyEventEntry> BunnyEvents;
    [SerializeField]
    public List<BunnyFactEntry> BunnyFacts;
    [SerializeField]
    public List<BunnyRuleEntry> BunnyRules;

    public BunnyDialogueDatabaseCollection(string name)
    {
        Name = name;
        Events = new Dictionary<string, BunnyEventEntry>();
        Facts = new Dictionary<string, BunnyFactEntry>();
        Rules = new Dictionary<string, BunnyRuleEntry>();

        BunnyEvents = new List<BunnyEventEntry>();
        BunnyFacts = new List<BunnyFactEntry>();
        BunnyRules = new List<BunnyRuleEntry>();
    }

    public virtual void Initialize() {}

    public T GetEntry<T>(string Key) where T : BunnyBaseEntry
    {
        Type entryType = typeof(T);
        if(entryType == typeof(BunnyEventEntry))
        {
            return (T) (object) Events[Key];
        }
        else if(entryType == typeof(BunnyFactEntry))
        {
            return (T) (object) Facts[Key];
        }
        else if(entryType == typeof(BunnyRuleEntry))
        {
            return (T) (object) Rules[Key];
        } 
        return default(T);
    }

    public BunnyEventEntry GetEvent(string Key)
    {
        return Events[Key];
    }

    public BunnyFactEntry GetFact(string Key)
    {
        return Facts[Key];
    }

    public BunnyRuleEntry GetRule(string Key)
    {
        return Rules[Key];
    }

    public void AddEntry<T>(T entry) where T : BunnyBaseEntry
    {
        if(entry.GetType() == typeof(BunnyEventEntry))
        {
            AddEventEntry((BunnyEventEntry) (object) entry);
        }
        else if(entry.GetType() == typeof(BunnyFactEntry))
        {
            AddFactEntry((BunnyFactEntry) (object) entry);
        }
        else if(entry.GetType() == typeof(BunnyRuleEntry))
        {
            AddRuleEntry((BunnyRuleEntry) (object) entry);
        }
    }

    public void AddEventEntry(BunnyEventEntry entry)
    {
        if(Events.ContainsKey(entry.Key)) {
            Debug.LogWarning($"[BunnyDialogueSystem] Attempt made to overwrite event entry {entry.Key} in [Collection: {Name}]");
            return;
        }
        Events.Add(entry.Key, entry);
        BunnyEvents.Add(entry);
    }

    public void AddFactEntry(BunnyFactEntry entry)
    {
        if(Facts.ContainsKey(entry.Key)) {
            Debug.LogWarning($"[BunnyDialogueSystem] Attempt made to overwrite fact entry {entry.Key} in [Collection: {Name}]");
            return;
        }
        Facts.Add(entry.Key, entry);
        BunnyFacts.Add(entry);
    }

    public void AddRuleEntry(BunnyRuleEntry entry)
    {
        if(Rules.ContainsKey(entry.Key)) {
            Debug.LogWarning($"[BunnyDialogueSystem] Attempt made to overwrite rule entry {entry.Key} in [Collection: {Name}]");
            return;
        }
        Rules.Add(entry.Key, entry);
        BunnyRules.Add(entry);
    }

    public void RemoveFact(string FactKey)
    {
        if(Facts.ContainsKey(FactKey))
        {
            BunnyFactEntry entry = Facts[FactKey];
            BunnyFacts.Remove(entry);

            Facts.Remove(FactKey);
        }
    }

    public void RemoveRule(string RuleKey)
    {
        if(Rules.ContainsKey(RuleKey))
        {
            BunnyRuleEntry entry = Rules[RuleKey];
            BunnyRules.Remove(entry);

            Rules.Remove(RuleKey);
        }
    }

    public void RemoveEvent(string EventKey)
    {
        if(Events.ContainsKey(EventKey))
        {
            BunnyEventEntry entry = Events[EventKey];
            BunnyEvents.Remove(entry);

            Events.Remove(EventKey);
        }
    }

}
