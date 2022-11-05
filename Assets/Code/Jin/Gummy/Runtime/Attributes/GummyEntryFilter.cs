using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Entries;

// Used for the custom editor views

namespace Jin.Gummy.Attributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class GummyEntryFilter : Attribute
    {
        public bool AllowEmpty {get; set;}
        public Type Base {get; set;}
        public GummyEntryType PreferredType {get; set;}
        public string TableName {get; set;}
        public GummyEntryType Type {get; set;}
    }
}