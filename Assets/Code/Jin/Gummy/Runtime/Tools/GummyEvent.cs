using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Jin.Gummy.Attributes;
using Jin.Gummy.Blackboard;
using Jin.Gummy.Entries;
using Jin.Gummy.Shared;
using Jin.Gummy.References;
using System;

namespace Jin.Gummy.Tools
{
    public class GummyEvent
    {
        [SerializeField]
        [GummyEntryFilter(PreferredType = GummyEntryType.Event, Type = GummyEntryType.Event | GummyEntryType.Rule, AllowEmpty = true)]
        public GummyEntryReference eventReference;

        // Context field of blackboard type
        [SerializeField]
        public GummyBlackboard context;

        // Later, we'll have a duplicate function that allows a custom Blackboard context to pass in
        public void Invoke(GummyEventBus eventBus)
        {
            Assert.IsNotNull(eventBus, "[Jin]: Missing EventBus. Event will not be invoked");
            if(eventReference.HasValue)
            {
                eventBus.Invoke(eventReference, context);
            }
        }

        
        public void Invoke(GummyEventBus eventBus, GummyBlackboard customContext)
        {
            Assert.IsNotNull(eventBus, "[Jin]: Missing EventBus. Event will not be invoked");
            if(eventReference.HasValue)
            {
                eventBus.Invoke(eventReference, customContext);
            }
        }

        [Serializable]
        internal struct Dispatcher
        {
            // [EntryFilter(Type = EntryType.Event)]
        }
    }
}
