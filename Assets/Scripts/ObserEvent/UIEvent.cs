using UnityEngine;

public class UIEvent : MonoBehaviour
{
     [SerializeField]
    ObjEvent objEvent;
    void Start()
    {
        objEvent.NoParameter += UpdateUI;
        objEvent.OneParameter += UpdateScore;
        objEvent.TwoParameter += MultiplayValues;
        // objEvent.unityEventsPar.AddListener(MultiplayValues);
    }

    void UpdateUI()
    {
        Debug.LogError($"Update UI {this.name}");
    }
    void UpdateScore(int score)
    {
        Debug.LogError($"Update Score {score} {this.name}");
    }

    void MultiplayValues(int i, int j)
    {
        Debug.LogError($"Play Two Paramter Sounds {i*j}");
        objEvent.Calc(Init);
    }

    void Init()
    {
        Debug.LogError($"Init Function is Activated");
    }
}
