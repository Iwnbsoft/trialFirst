﻿using System;
using System.Collections;
using System.Collections.Generic;
using topDownShooter.PlayerInput;
using UnityEngine;

namespace topDownShooter.PlayerControls
{

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private AbstractInputData _inputData;
    [SerializeField] private PlayerMovementSettings _playerMovementSettings;
    [SerializeField] private Transform _targetTransform;
    //[SerializeField] private ControlRigidbodySettings _settings;

    private void Update()
    {
        _rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.forward * _inputData.Vertical * _playerMovementSettings.VerticalSpeed));
        _targetTransform.Rotate(0,_inputData.Horizontal * _playerMovementSettings.HorizontalSpeed,0, Space.Self);
        //_rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.right * _inputData.Horizontal * _playerMovementSettings.HorizontalSpeed));
        
        /*
         bool spaceGetDown = Input.GetKeyDown(KeyCode.Space);
        if (spaceGetDown)
        {
            _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
        }
        */
    }
}    
} 