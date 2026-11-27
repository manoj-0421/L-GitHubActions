using UnityEngine;
using System.Collections.Generic;
public class GameEventsListener : MonoBehaviour
{
    public List<GameEventsContainer> eventContainer = new List<GameEventsContainer>();


    void OnEnable()
    {
        foreach(var listener in eventContainer)
        {
            listener.SubscribeGameevent();
        }
    }

    void OnDisable()
    {
        foreach(var listener in eventContainer)
        {
            listener.UnSubscribeGameevent();
        }
    }
}
