using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Bad attempt from @Mohammedajao to visualize the events in Unity
*/

public interface IBunnyEvent {
    public void OnEventRaised<T>(Action<BunnyBrokerMessage<T>> del);
    public void Disconnect<T>(Action<BunnyBrokerMessage<T>> subscription);
    public void Fire<T>(BunnyBrokerMessage<T> message);
}

public interface IBunnyEventArgs {}

public abstract class IBunnyBrokerEventHandler {

}

[CreateAssetMenu(menuName = "Bunny/Core/BunnyEvent")]
public class BunnyEvent : ScriptableObject, IBunnyEvent
{
    [SerializeField] private string eventName;
    public String EventName => eventName;
    public object Sender;
    private Dictionary<Type, List<Delegate>> _subscribers;

    public BunnyEvent()
    {
        eventName = "";
        Sender = this;
        _subscribers = new Dictionary<Type, List<Delegate>>();
    }

    public BunnyEvent(string name, object source)
    {
        eventName = name;
        Sender = source;
        _subscribers = new Dictionary<Type, List<Delegate>>();
    }

    public void OnEventRaised<T>(Action<BunnyBrokerMessage<T>> callback)
    {
        var payloadType = typeof(T);
        if(!_subscribers.ContainsKey(payloadType))
        {
            _subscribers.Add(payloadType, new List<Delegate>());
        }
        if(!_subscribers[payloadType].Contains(callback))
            _subscribers[payloadType].Add(callback);
    }

    public void Fire<T>(BunnyBrokerMessage<T> message)
    {
        var payloadType = typeof(T);
        if(!_subscribers.ContainsKey(payloadType)) {
            Debug.LogWarning($"No subscribers found for BunnyEvent<{payloadType}> for EventName: {EventName}. Please check your code to see if subscribers are intentionally excluded.");
            return;
        }

        var delegates = _subscribers[typeof(T)];
        if (delegates == null || delegates.Count == 0) return;

        foreach(var handler in delegates.Select(item => item as Action<BunnyBrokerMessage<T>>))
        {
            handler?.Invoke(message);
        }
    }

    public void Disconnect<T>(Action<BunnyBrokerMessage<T>> subscription)
    {
        if(!_subscribers.ContainsKey(typeof(T)))
            return;
        List<Delegate> delegates = _subscribers[typeof(T)];
        if(delegates == null)
            return;
        if (delegates.Contains(subscription))
            delegates.Remove(subscription);
        if (delegates.Count == 0)
            _subscribers.Remove(typeof(T));
    }

    public void Disable()
    {
        _subscribers.Clear();
    }

    public void ListSubscriberTypes()
    {
        Debug.Log("Sub types requested");
        string output = "Event Subscriber Types: ";
        foreach (KeyValuePair<Type, List<Delegate>> kvp in _subscribers)
        {
            //textBox3.Text += ("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            output += string.Format("Key = {0}", kvp.Key);
        }
        Debug.Log(output);
    }
}