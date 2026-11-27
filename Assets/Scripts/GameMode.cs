using UnityEngine;

namespace com.manoj.Test
{
    public class GameMode : MonoBehaviour
    {
        public void Awake()
        {
            ServiceLocator.Register<GameMode>(this);
        }
        public void _name()
        {
            Debug.LogError($"Name : {this.name}");
        }
       public void CalUnityEvent()
        {
            Debug.LogError($"[GameMode] Unityevent");
        }
        public void CalGameEvent()
        {
            Debug.LogError($"[GameMode] Gameevent");
        }
    }
}
