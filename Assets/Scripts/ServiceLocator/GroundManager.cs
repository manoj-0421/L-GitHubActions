using UnityEngine;

public class GroundManager : MonoBehaviour
{
   void Start()
    {
        ServiceLocator.Register<GroundManager>(this);
    }
}
