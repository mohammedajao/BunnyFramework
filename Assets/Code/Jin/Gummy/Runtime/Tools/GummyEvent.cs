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

// IGNORE FOR NOW
        [Serializable]
        internal struct Dispatcher
        {
            [GummyEntryFilter(Type = GummyEntryType.Event)]
            public GummyEntryReference entry;

            // Some references for help: https://gist.github.com/keless/8727613
            // https://www.google.com/search?q=c%23+event.dispatcher&rlz=1C1VDKB_enUS929US929&oq=c%23+event.dispatcher&aqs=chrome..69i57j0i22i30l6j69i58.5611j0j4&sourceid=chrome&ie=UTF-8
            // https://ootii.com/knowledge-base/event-dispatcher/
        }
    }
}
