using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Jin.Gummy.Blackboard;

namespace Jin.Gummy.Shared
{
    public delegate void EventBusAction(int id, IGummyBlackboard context);

    [CreateAssetMenu(fileName = "GummyEventBus", menuName="GummyEvents/Bus")]
    public class GummyEventBus : ScriptableObject
    {
        private readonly Dictionary<int, EventBusAction> _events = new();
        private event EventBusAction GlobalEvent;

        public void AddListener(EventBusAction action)
        {
            GlobalEvent += action;
        }

        public void RemoveListener(EventBusAction action)
        {
            GlobalEvent -= action;
        }

        public void AddListener(int id, EventBusAction action)
        {
           if (_events.ContainsKey(id)) 
           {
                _events[id] += action;
           } else {
                _events[id] = action;
           }
        }

        public void RemoveListener(int id, EventBusAction action)
        {
           if (_events.ContainsKey(id)) 
           {
                var listeners = _events[id] - action;
                if (listeners == null)
                {
                    _events.Remove(id);
                } else {
                    _events[id] = listeners;
                }
           } 
        }

        public void Invoke(int id, GummyBlackboard context)
        {
            if (id == 0)
                return;
            GlobalEvent?.Invoke(id, context);
            if (_events.TryGetValue(id, out var callbacks))
            {
                callbacks.Invoke(id, context);
            }
        }
    }
}
