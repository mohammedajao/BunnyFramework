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
            // Some references for help: https://gist.github.com/keless/8727613
            // https://www.google.com/search?q=c%23+event.dispatcher&rlz=1C1VDKB_enUS929US929&oq=c%23+event.dispatcher&aqs=chrome..69i57j0i22i30l6j69i58.5611j0j4&sourceid=chrome&ie=UTF-8
            // https://ootii.com/knowledge-base/event-dispatcher/

            public void Subscribe()
            {
                // Add Listener
            }

            public void Dispatch()
            {
                // Send message
            }
        }
    }
}
