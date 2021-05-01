using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

namespace topDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "topDown Shooter/Inventory/Player Inventory Cannon Item Data")]
public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCanonItemMono>
{
    [SerializeField] private float _damage;
    public float Damage
    {
        get { return _damage; }
    }

    [SerializeField] private float _rpm = 1f;
    public float RPM
    {
        get { return _rpm; }
    }
    
    private float _lastShootTime;

    public override void Initialize(PlayerInventoryController targetPlayerInventory)
    { 
        base.Initialize(targetPlayerInventory);
        InstantiateAndInitialiazePrefab(targetPlayerInventory.CanonParent);
        targetPlayerInventory.ReactiveShootCommand.Subscribe(onReactiveShootCommand).AddTo(_compositeDisposable);
        Debug.Log("Canon item data");
    }

    public override void Destroy()
    {
        //means that we are unsubscribing from all the events we add to this
        _compositeDisposable.Dispose();
        base.Destroy();
    }

    private void onReactiveShootCommand(Unit obj)
    {
        Debug.Log("reactive command shoot");
        Shoot();
    }

    public void Shoot()
    {
        if (Time.time - _lastShootTime > _rpm)
        {
            _instantiated.Shoot();
            _lastShootTime = Time.time;
        }
        else
        {
            Debug.LogError("you can't shoot now");
        }
    }
    
}    
}
