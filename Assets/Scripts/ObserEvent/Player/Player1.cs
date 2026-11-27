using UnityEngine;

public class Player1 : MonoBehaviour, IObserver
{
    public void Notify()
    {
        Debug.LogError($"On Notify {this.name}");
    }
}
