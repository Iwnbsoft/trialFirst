using System;
using System.Collections;
using System.Collections.Generic;
using topDownShooter.PlayerInput;
using UnityEngine;

namespace topDownShooter.PlayerControls
{
    public class TowerRotationController : MonoBehaviour
    {
        [SerializeField] private AbstractInputData _rotationInput;
        [SerializeField] private Transform _towerTransform;
        [SerializeField] private TowerRotationSettings _towerRotationSettings;

        private void Update()
        {
            _towerTransform.Rotate(0,_rotationInput.Horizontal * _towerRotationSettings.towerRotationSpeed,0,Space.Self);
        }
    }
}