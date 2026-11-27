using UnityEngine;

public class UnityEven : MonoBehaviour
{
    public void Func1()
    {
        Debug.LogError($"Function 1");    
    }

    public void Function2(int i, int j)
    {
        Debug.LogError($"Function Mul {i*j}");
    }
    public void Function3()
    {
        Debug.LogError($"Function Mul No Par");
    }
}
