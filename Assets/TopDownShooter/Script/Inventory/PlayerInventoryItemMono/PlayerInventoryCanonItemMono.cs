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

}
}
