using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Jin.Gummy.Shared
{
    private delegate void EventBusAction(int id);

    [CreateAssetMenu(filename = "GummyEventBus", menuName="GummyEvents/Bus")]
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

        public void RemoveListener(int id, EventBusAction aciton)
        {
           if (_events.ContainsKey(id)) 
           {
                var listeners = _events[id] - action;
                if (listners == null)
                {
                    _events.Remove(id);
                } else {
                    _events[id] = listeners;
                }
           } 
        }

        public void Invoke(int id)
        {
            if (id == 0)
                return;
            GlobalEvent?.Invoke(id);
            if (_events.TryGetValue(id, out var callbacks))
            {
                callbacks.Invoke(id);
            }
        }
    }
}
