using UnityEngine;
using UnityEngine.Events;
using System;
[Serializable]
public class GameEventsContainer
{
   public GameEvents gameEvents;
   public UnityEvent unityEvent;

    public void SubscribeGameevent()
    {
        gameEvents.Add(this);
    }
    public void UnSubscribeGameevent()
    {
        gameEvents.Remove(this);
    }

    public void OnEventRaise()
    {
        unityEvent?.Invoke();
    }
}
