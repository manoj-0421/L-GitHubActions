using UnityEngine;

public class AudioManager : MonoBehaviour
{
    void Start()
    {
        ServiceLocator.Register<AudioManager>(this);
    }
}
