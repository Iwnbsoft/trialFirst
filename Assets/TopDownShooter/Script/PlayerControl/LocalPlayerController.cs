using System;
using System.Collections;
using System.Collections.Generic;
using topDownShooter.Inventory;
using topDownShooter.PlayerInput;
using UnityEngine;

namespace topDownShooter
{
public class LocalPlayerController : MonoBehaviour
{
    [SerializeField] private PlayerInventoryController _inventoryController;
    [SerializeField] private AbstractInputData _shootInput;

    private void Update()
    {
        if (_shootInput.Horizontal > 0)
        {
            _inventoryController.ReactiveShootCommand.Execute();
        }
    }
}
}
