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

        [SerializeField]
        public GummyBlackboard context;

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
            [GummyEntryFilter(Type = GummyEntryType.Event)]
            public GummyEntryReference entry;
        }
    }
}
