using UnityEngine;

namespace com.manoj.Test
{
    public class Ground : MonoBehaviour
    {
        public void Awake()
        {
            ServiceLocator.Register<Ground>(this);
        }
        public void _name()
        {
            Debug.LogError($"Name : {this.name}");
        }

        public void CalUnityEvent()
        {
            Debug.LogError($"[Ground] Unityevent");
        }
        public void CalGameEvent()
        {
            Debug.LogError($"[Ground] Gameevent");
        }
    }
}
