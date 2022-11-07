using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Redcode.Pools;

public class UnitManager : MonoBehaviour
{
    private static UnitManager inst;
    public static UnitManager Inst
    {
        get { return inst; }
    }

    private PoolManager poolManager;
    private void Awake()
    {
        if (inst)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            inst = this;
            poolManager = GetComponent<PoolManager>();

            SpawnUnit();
        }
    }

    public void SpawnUnit()
    {
        UnitBase newUnit = poolManager.GetFromPool<UnitBase>();
    }
    void ReturnPool(UnitBase unit)
    {
        poolManager.TakeToPool<UnitBase>(unit);

    }
}
