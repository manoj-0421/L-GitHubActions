using UnityEngine;
using UnityEngine.Events;
using System;
using System.Collections;
public class ObjEvent : MonoBehaviour
{
    [SerializeField]
    UnityEvent unityEvents;

    public UnityEvent<int, int> unityEventsPar;
    public Action NoParameter;

    public Action<int> OneParameter;

    public Action<int,int> TwoParameter;

    void Start()
    {
        StartCoroutine(_wait(2.0f));
    }
    IEnumerator _wait(float time)
    {
        yield return new WaitForSeconds(time);
        // NoParameter?.Invoke();
        int val = 25;
        int val_1 = 253;
        // OneParameter?.Invoke(val);
        //TwoParameter?.Invoke(val,val_1);
        // unityEvents?.Invoke();
        unityEventsPar?.Invoke(val,val_1);
    }

    public void Calc(Action _callback)
    {
        _callback?.Invoke();
    }
}
