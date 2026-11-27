using UnityEngine;

namespace com.manoj.Test
{
    public class ScriptManager : MonoBehaviour
    {
        // [SerializeField]
        Ground groundScript;
        // [SerializeField]
        MainMenu menuScript;
        // [SerializeField]
        GameMode gameMiodeScript;

        // [SerializeField]
        CutScene Cs;
        [SerializeField]
        CreateScriptable createScriptable;

        public void Awake()
        {
            ServiceLocator.Register<ScriptManager>(this);
        }
        public void Start()
        {
            // Debug.LogError($"Call Func {createScriptable.callback()}");
            // Debug.LogError($"Call Func {createScriptable.add(5000,7000)}");
            // if(Cs == null)
            // {
            //     Cs = ServiceLocator.GetService<CutScene>();
            //     Cs.Init(ServiceLocator.GetService<Ground>(),ServiceLocator.GetService<GameMode>(),ServiceLocator.GetService<MainMenu>());
            // }
        }
    }
}
