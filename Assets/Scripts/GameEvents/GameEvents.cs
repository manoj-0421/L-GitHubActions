using UnityEngine;
using System.Collections.Generic;
[CreateAssetMenu(fileName="GameEvent",menuName="CreateGameEvent")]
public class GameEvents : ScriptableObject
{
    List<GameEventsContainer> container = new List<GameEventsContainer>();

    public void Add(GameEventsContainer eventContainer)
    {
        container.Add(eventContainer);
    }

    public void Remove(GameEventsContainer eventContainer)
    {
        container.Remove(eventContainer);
    }

    public void Raise()
    {
        for(int i = container.Count-1; i >= 0; i--)
        {
            container[i]?.OnEventRaise();
        }
    }
}
