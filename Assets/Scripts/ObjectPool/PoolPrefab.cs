using System.Collections;
using UnityEngine;
public class PoolPrefab : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    GameObject prefab1;

    [SerializeField]
    MultiGameObjectPool multiGameObjectPool;
    GameObject currentPrefab;
    void Awake()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            currentPrefab = multiGameObjectPool.Spawn(prefab,Random.insideUnitSphere * 5f, this.gameObject.transform);
            // Return it to the pool after a short delay.
            StartCoroutine(ReturnAfter(currentPrefab, 2f));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            currentPrefab = multiGameObjectPool.Spawn(prefab1,Random.insideUnitSphere * 5f, this.gameObject.transform);
            // Return it to the pool after a short delay.
            StartCoroutine(ReturnAfter(currentPrefab, 2f));
        }
    }
    IEnumerator ReturnAfter(GameObject gameObject, float time)
    {
        yield return new WaitForSeconds(time);
        multiGameObjectPool.DeSpawn(gameObject);
    }
}
