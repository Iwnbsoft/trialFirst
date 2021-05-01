using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Inventory
{
public class PlayerInventoryCanonItemMono : AbstractPlayerInventoryItemMono
{
    [SerializeField] private Transform _cannonShootPoint;

    public void Shoot()
    {
        //add also effect and such
        ScriptableShootManager.Instance.Shoot(_cannonShootPoint.position, _cannonShootPoint.forward);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawSphere(_cannonShootPoint.position, .15f);
        Gizmos.color = Color.black;
        Gizmos.DrawLine(_cannonShootPoint.position, _cannonShootPoint.position + _cannonShootPoint.forward * 10);
    }
}
}
