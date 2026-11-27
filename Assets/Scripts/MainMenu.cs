using UnityEngine;

namespace com.manoj.Test
{
    public class MainMenu : MonoBehaviour
    {
        public void Awake()
        {
            ServiceLocator.Register<MainMenu>(this);
        }
        public void _name()
        {
            Debug.LogError($"Name : {this.name}");
        }
       public void CalUnityEvent()
        {
            Debug.LogError($"[MainMenu] Unityevent");
        }
        public void CalGameEvent()
        {
            Debug.LogError($"[MainMenu] Gameevent");
        }
    }
}
