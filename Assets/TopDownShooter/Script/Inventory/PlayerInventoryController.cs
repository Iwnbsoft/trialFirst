using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Inventory
{

public class PlayerInventoryController : MonoBehaviour
{
    [SerializeField] private AbstractBasePlayerInventoryItemData[] _inventoryItemDataArray;
    public Transform parent;

    //FOR TESTİNG
    private void Start()
    {
        initializeInventory(_inventoryItemDataArray);
    }

    public void initializeInventory(AbstractBasePlayerInventoryItemData[] inventoryItemDataArray)
    {
        for (int i = 0; i < inventoryItemDataArray.Length; i++)
        {
            inventoryItemDataArray[i].CreateIntoInventory(this);
        }
    }
}
}
