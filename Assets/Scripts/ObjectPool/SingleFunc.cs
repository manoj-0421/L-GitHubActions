using UnityEngine;
using UnityEngine.Pool;
using System.Collections;
using System.Collections.Generic;

public class SingleFunc : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    ObjectPool<GameObject> poolObjects;

    void Awake()
    {
        GameObject Go;
        poolObjects = new ObjectPool<GameObject>(
            createFunc:()=>
            {
                Go = Instantiate(prefab);
                return Go;
            },
            actionOnGet:Go => Go.SetActive(true),
            actionOnRelease:Go => Go.SetActive(false),
            actionOnDestroy:Go =>  Destroy(Go),
            collectionCheck:true,
            defaultCapacity:10,
            maxSize:50
        );
        StartCoroutine(DuplicatePrefab(Random.Range(0.2f,0.5f)));
    }

    IEnumerator DuplicatePrefab(float time)
    {
        yield return new WaitForSeconds(time);
        GameObject GO = poolObjects.Get();
        GO.transform.position = Random.insideUnitSphere * 5;
        StartCoroutine(DuplicatePrefab(Random.Range(1,3)));
        StartCoroutine(ReturnToPool(GO,Random.Range(2,8)));
    }

    IEnumerator ReturnToPool(GameObject _go,float time)
    {
        yield return new WaitForSeconds(time);
        poolObjects.Release(_go);
    }
}
