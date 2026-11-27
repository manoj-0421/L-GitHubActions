using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections;
public class Events : MonoBehaviour
{
    [SerializeField]GameEvents playGameEvent;
    [SerializeField]GameEvents pauseGameEvent;
    [SerializeField] UnityEvent unityEvent;

    [SerializeField] SyaAction m_Action;
    [SerializeField] Event m_event;
    void Awake()
    {
    //    StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        // m_event += check;
        unityEvent?.Invoke();
        // m_event();
        yield return new WaitForSeconds(1.0f);
        Debug.LogError($"Wait Function");
        playGameEvent?.Raise();
        pauseGameEvent?.Raise();
        // m_Action.CallBackFunc(_print,GetNumber);
    }
    // void check()
    // {
    //     Debug.LogError($"Check Function");    
    // }
    void _print()
    {
        Debug.LogError($"_Print Function");
    }

    void GetNumber(int b)
    {
        Debug.LogError($"GetNumber {b}");
    }
}
