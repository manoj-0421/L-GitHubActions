using UnityEngine;

public class Player2 : MonoBehaviour, IObserver
{
    public void Notify()
    {
        Debug.LogError($"On Notify {this.name}");
    }
}
