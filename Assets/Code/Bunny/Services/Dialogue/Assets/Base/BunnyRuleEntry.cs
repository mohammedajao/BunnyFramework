using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BunnyRulePriority
{
    Low,
    Medium,
    High
}

// Core building block of dialogue
// When an event is dispatched, all rules listening to it are gathered 1 by 1
// The rule that matches with the highest specificity (most criteria matched) runs
// Algorithm should have a sorted collection for rules as the algorithm should stop at the first rule found.

// Events are also facts under the hood can be considered within the criterion.
// Conversations that have several rules will use the same event.
// They'll have criteria that requires the event entry to be their position in the dialogue sequence.

[CreateAssetMenu(fileName = "BunnyRuleEntry", menuName = "Dialogue/Entries/BunnyRuleEntry")]
public class BunnyRuleEntry : BunnyBaseEntry
{
    public List<BunnyDialogueCriteria> criterion;
    public List<BunnyEntryModification> modifications;
    public bool Once;
    public bool IsCancellable;
    public float Padding;
    public float Delay;
    public BunnyEventEntry TriggeredBy;
    public BunnyEventEntry Triggers;
    public BunnyFactEntry Speaker;
    public string Text;

    public BunnyRuleEntry(
        string RuleKey,
        List<BunnyDialogueCriteria> criteria,
        BunnyEventEntry trigger,
        BunnyFactEntry speaker,
        string dialogue,
        List<BunnyEntryModification> mods
    )
    {
        this.Key = RuleKey;
        criterion = criteria;
        TriggeredBy = trigger;
        this.Speaker = speaker;
        Text = dialogue;
        TriggeredBy.AddNext(this);
        modifications = mods;

        Action<BunnyBrokerMessage<int>> callback = Execute;
        TriggeredBy.ClientEvent.OnEventRaised<int>(callback);
    }

    public BunnyRuleEntry(
        string RuleKey,
        List<BunnyDialogueCriteria> criteria,
        BunnyEventEntry trigger,
        BunnyFactEntry speaker,
        string dialogue,
        BunnyEventEntry next,
        List<BunnyEntryModification> mods
    )
    {
        this.Key = RuleKey;
        criterion = criteria;
        TriggeredBy = trigger;
        TriggeredBy.AddNext(this);
        this.Speaker = speaker;
        Text = dialogue;
        Triggers = next;
        Triggers.AddPrevious(this);
        modifications = mods;

        Action<BunnyBrokerMessage<int>> callback = Execute;
        TriggeredBy.ClientEvent.OnEventRaised<int>(callback);
    }

    public bool Validate()
    {
        for(var i=0; i < criterion.Count; i++)
        {
            if(!criterion[i].IsSatisfied()) 
                return false;
        }
        return true;
    }

    // Int passed will be event entry ID
    public void Execute(BunnyBrokerMessage<int> message)
    {
        for(var i=0; i < criterion.Count; i++)
        {
            if(!criterion[i].IsSatisfied()) 
                return;  
        }
        BunnySpeakerComponent speakerEnt = BunnyDialogueManager.Instance.Speakers.GetItemIndex(Speaker);
        for(int i=0; i < modifications.Count; i++)
        {
            BunnyEntryModification mod = modifications[i];
            mod.Modify();
        }
        speakerEnt.Speak(Text);
    }

    public int GetPriority()
    {
        return criterion.Count;
    }
}
