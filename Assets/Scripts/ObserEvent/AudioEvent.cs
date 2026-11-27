using UnityEngine;

public class AudioEvent : MonoBehaviour
{
    [SerializeField]
    ObjEvent objEvent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        objEvent.NoParameter += PlayAudio;
        objEvent.OneParameter += PlayOneParamterSound;
        objEvent.TwoParameter += PlayTwoParameterSound;
    }

    void PlayAudio()
    {
        Debug.LogError($"PlayAudio {this.name}");
    }

    void PlayOneParamterSound(int val)
    {
        Debug.LogError($"PlayOneParamterSound {val} {this.name}");
    }

    void PlayTwoParameterSound(int i, int j)
    {
        Debug.LogError($"Play Two Paramter Sounds");
    }
}
