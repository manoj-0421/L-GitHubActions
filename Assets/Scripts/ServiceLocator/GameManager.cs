using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        ServiceLocator.Register<GameManager>(this);
    }
}
