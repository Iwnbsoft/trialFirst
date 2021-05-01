using System;
using System.Collections;
using System.Collections.Generic;
using topDownShooter.PlayerInput;
using UnityEngine;

public class PlayerRotationController : MonoBehaviour
{
    [SerializeField] private AbstractInputData _inputData;
    [SerializeField] private Transform _tower;

    void Update()
    {
        _tower.Rotate(0, _inputData.Horizontal, 0, Space.Self);
    }
}
