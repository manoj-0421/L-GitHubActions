using UnityEngine;
using UnityEngine.Pool;
using System.Collections.Generic;

public class MultiGameObjectPool : MonoBehaviour
{
   Dictionary<GameObject, IObjectPool<GameObject>> Pools = new();

   Dictionary <GameObject, IObjectPool<GameObject>> InstancePools = new();


   public GameObject Spawn(GameObject Prefab, Vector3 trans, Transform transform)
   {
        if(Pools.TryGetValue(Prefab, out var Obj) is false)
        {
            Obj = CreateItem(Prefab);
            Pools.Add(Prefab, Obj);
        }
        GameObject returnGO = Obj.Get();
        returnGO.transform.position = trans;
        returnGO.transform.SetParent(transform);
        return returnGO;
   }

   public void DeSpawn(GameObject Prefab)
   {
        if(InstancePools.TryGetValue(Prefab, out var Obj))
        {
            Obj.Release(Prefab);
            Prefab.transform.SetParent(this.gameObject.transform);
        }
        else
        {
            Destroy(Prefab);
        }
   }
   IObjectPool<GameObject> CreateItem(GameObject item)
    {
        IObjectPool<GameObject> newPool = null;
        newPool = new ObjectPool<GameObject>(
            createFunc:() =>
            {
                GameObject Prefab = Instantiate(item);
                InstancePools[Prefab] = newPool;
                return Prefab;
            },
            actionOnGet: item => item.SetActive(true),
            actionOnRelease:item => item.SetActive(false),
            actionOnDestroy:item =>
            {
                InstancePools.Remove(item);
                Destroy(item);
            },
            collectionCheck:true,
            defaultCapacity:10,
            maxSize:25
        );
        return newPool;
    }
}
