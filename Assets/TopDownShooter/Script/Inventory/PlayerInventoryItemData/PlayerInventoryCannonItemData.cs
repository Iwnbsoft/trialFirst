using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "topDown Shooter/Inventory/Player Inventory Cannon Item Data")]
public class PlayerInventoryCannonItemData : AbstractPlayerInventoryItemData<PlayerInventoryCanonItemMono>
{
    public override void CreateIntoInventory(PlayerInventoryController targetPlayerInventory)
    {
        var instantiated = InstantiateAndInitialiazePrefab(targetPlayerInventory.parent);
        Debug.Log("Canon item data");
    }
}    
}
