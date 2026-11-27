using UnityEngine;
using System.Collections;
public class Dele : MonoBehaviour
{
    public delegate void MyDelegate();
    public delegate void MyDelegateWithPar(int score);
    MyDelegate myDelegate;

    MyDelegateWithPar myDeleWithPar;
    [SerializeField]
    DelPlayer delPlayer;
    void Start()
    {
       myDelegate = delPlayer.OnAttack;
       myDeleWithPar = delPlayer.OnUpdateScore;
       StartCoroutine(Call(2.0f));
    }

    IEnumerator Call(float time)
    {
        yield return new WaitForSeconds(time);
        myDelegate();
        myDeleWithPar(50);
    }
}
