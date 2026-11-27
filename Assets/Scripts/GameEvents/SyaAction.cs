using UnityEngine;
using System;
using System.Collections;
public class SyaAction : MonoBehaviour
{
    Action callbacks;
    Action<int> action1;
    int _c;
    public void CallBackFunc(Action action, Action<int> A1)
    {
        callbacks = action;
        action1 = A1;
        _c = 24*7;
        StartCoroutine(_Wait());
    }

    IEnumerator _Wait()
    {
        yield return new WaitForSeconds(3.0f);
        callbacks?.Invoke();
        action1?.Invoke(_c);
    }
}
