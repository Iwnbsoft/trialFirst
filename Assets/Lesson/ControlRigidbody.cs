using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.PlayerMovement
{
    public class ControlRigidbody : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private ControlRigidbodySettings _settings;
        private void Update()
        {
            bool spaceGetDown = Input.GetKeyDown(KeyCode.Space);
            if (spaceGetDown)
            {
                _rigidbody.AddForce(_settings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}
