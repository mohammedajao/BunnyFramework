using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ID represents the amount of times event was triggered

[CreateAssetMenu(fileName = "BunnyEventEntry", menuName = "Dialogue/Entries/BunnyEventEntry")]
public class BunnyEventEntry : BunnyBaseEntry
{
    public List<BunnyDialogueCriteria> criterion;
    [SerializeField] public bool Once;
    public BunnyEvent ClientEvent;
    public BunnySortedRuleList NextRules;
    public BunnySortedRuleList PreviousRules;
    // public Dictionary<string, BunnyDialogueRule> Branches;
    private static BunnyEventEntry _none;

    public static BunnyEventEntry None
    {
        get
        {
            if(_none == null)
                _none = new BunnyEventEntry();
            return _none;
        }
    }


    private BunnyEventEntry()
    {
        this.ID = 0;
        this.Key = "";
        Once = true;
    }

    public BunnyEventEntry(
        string EventName,
        List<BunnyDialogueCriteria> policies,
        BunnyEvent evt,
        bool once = false
    )
    {
        this.ID = 0;
        this.Key = EventName;
        criterion = policies;
        Once = once;
        ClientEvent = evt;
        NextRules = new BunnySortedRuleList();
        PreviousRules = new BunnySortedRuleList();
    }

    public bool IsSatisfied()
    {
        for(int i = 0; i < criterion.Count; i++)
        {
            BunnyDialogueCriteria policy = criterion[i];
            if(!policy.IsSatisfied()) {
                return false;
            }
        }
        return true;
    }

    public void AddNext(BunnyRuleEntry rule)
    {
        NextRules.Add(rule);
    }

    public void AddPrevious(BunnyRuleEntry rule)
    {
        PreviousRules.Add(rule);
    }

    public void FireNextRule(BunnyBrokerMessage<int> payload)
    {
        foreach(BunnyRuleEntry rule in NextRules)
        {
            if(rule.Validate() && !(rule.Once && rule.ID > 0)) {
                if(rule.Triggers != null)
                    rule.Triggers.Raise();
                return;
            }
        }
    }

    public void Raise()
    {
        if(!IsSatisfied())
            return;

        BunnyBrokerMessage<int> payload = new BunnyBrokerMessage<int>(this.ID, this);
        if(this.Once && this.ID >= 1) {
            FireNextRule(payload);
            return;
        }
        ClientEvent.Fire<int>(payload);
        this.ID += 1;
    }

    public void Bind<T>(Action<BunnyBrokerMessage<T>> callback)
    {
        ClientEvent.OnEventRaised(callback);
    }

    public void Unbind<T>(Action<BunnyBrokerMessage<T>> callback)
    {
        ClientEvent.Disconnect<T>(callback);
    }

    public void OnDisable()
    {
        if(ClientEvent != null)
            ClientEvent.Disable();
    }
}
