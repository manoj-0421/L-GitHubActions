using UnityEngine;

namespace com.manoj.Test
{
    public class CutScene : MonoBehaviour
    {
        Ground groundScript;
        GameMode gamemodeScript;
        MainMenu mainmenuScript;

        public void Awake()
        {
            ServiceLocator.Register<CutScene>(this);
            // Init();
        }
        public void Init()
        {
            groundScript = ServiceLocator.GetService<Ground>();;
            gamemodeScript = ServiceLocator.GetService<GameMode>();;
            mainmenuScript = ServiceLocator.GetService<MainMenu>();;
           
            groundScript._name();
            gamemodeScript._name();
            mainmenuScript._name();
            // ScriptManager sc;
            // Debug.LogError(ServiceLocator.TryGetService<ScriptManager>(out sc));
            // Debug.LogError($"ScriptManager {sc}");
            // Debug.LogError($"Add {manager.add(3,5)}");
        }
    }
}
