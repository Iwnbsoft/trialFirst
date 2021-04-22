using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace topDownShooter.Inventory
{
public abstract class AbstractBasePlayerInventoryItemData : ScriptableObject
{
    private PlayerInventoryController _inventoryController;
    protected CompositeDisposable _compositeDisposable;

    public virtual void Initialize(PlayerInventoryController targetPlayerInventory)
    {
        _inventoryController = targetPlayerInventory;
        _compositeDisposable = new CompositeDisposable();
    }

    public virtual void Destroy()
    {
        Destroy(this);
    }
}
}
