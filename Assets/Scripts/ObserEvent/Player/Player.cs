using UnityEngine;

public class Player : MonoBehaviour, IObserver
{
    [SerializeField]
    Player1 player1;
    [SerializeField]
    Player2 player2;
    public void Notify()
    {
        Debug.LogError($"On Notify {this.name}");
    }

    void Start()
    {
        GameSubject gameSubject = new GameSubject();
        gameSubject.Register(this);
        gameSubject.Register(player1);
        gameSubject.Register(player2);
        gameSubject.Notify();
    }
}
