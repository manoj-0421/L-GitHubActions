using UnityEngine;

public class DelPlayer : MonoBehaviour
{
    public void OnAttack()
    {
        Debug.LogError($"on Being Attack");
    }

    public void OnUpdateScore(int score)
    {
        Debug.LogError($"On Update Score {score}");
    }
}
