using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public enum BunnyEntryType 
{
    FACT,
    EVENT,
    RULE
}

[CreateAssetMenu(fileName = "BunnyBaseEntry", menuName = "Dialogue/Entries/BunnyBaseEntry", order = 0)]
public class BunnyBaseEntry : ScriptableObject {
    public int ID;
    public string Key = "";

    public override bool Equals(object obj)
    {  
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        BunnyBaseEntry entry = obj as BunnyBaseEntry;
        if(entry == null)
            return false;
        
        if(entry.Key == Key) {
            return true;
        }
        return false;
    }

    // override object.GetHashCode
    public override int GetHashCode() {
        if(Key == null)
            throw new NullReferenceException("Entry's key is null.");
        return (Key).GetHashCode();
    }
}