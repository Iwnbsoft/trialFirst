using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "topDown Shooter/Inventory/Player Inventory Body Item Data")]
public class PlayerInventoryBodyItemData : AbstractPlayerInventoryItemData<PlayerInventoryBodyItemMono>
{
    public override void Initialize(PlayerInventoryController targetPlayerInventory)
    {
        var instantiated = InstantiateAndInitialiazePrefab(targetPlayerInventory.parent);
        Debug.Log("Body item data");
    }
}
}

