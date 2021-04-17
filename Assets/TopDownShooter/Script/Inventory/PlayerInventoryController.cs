using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Inventory
{

public class PlayerInventoryController : MonoBehaviour
{
    [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
    private List<AbstractBasePlayerInventoryItemData> _instantiatedItemDataList;
    public Transform parent;

    //FOR TESTİNG
    private void Start()
    {
        initializeInventory(_inventoryItemDataArray);
    }

    private void OnDestroy()
    {
        ClearInventory();
    }

    public void initializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
    {
        ClearInventory();
        _instantiatedItemDataList = new List<AbstractBasePlayerInventoryItemData>(inventoryItemDataArray.Length);
        for (int i = 0; i < inventoryItemDataArray.Length; i++)
        {
            var instantiated = Instantiate(_inventoryItemDataArray[i]);
            instantiated.CreateIntoInventory(this);
            _instantiatedItemDataList.Add(instantiated);
        }
    }

    private void ClearInventory()
    {
        if (_instantiatedItemDataList != null)
        {
            for (int i = 0; i < _instantiatedItemDataList.Count; i++)
            {
                _instantiatedItemDataList[i].Destroy();
            }
        }
    }
}
}
