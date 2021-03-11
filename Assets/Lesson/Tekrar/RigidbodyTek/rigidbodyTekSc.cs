using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Derslerr
{
    public class rigidbodyTekSc : MonoBehaviour
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private rigidbodyTekSettings _rigidbodyTekSettings;

        private void Update()
        {
            bool spaceGetDown = Input.GetKeyDown(KeyCode.Space);

            if (spaceGetDown)
            {
                _rigidbody.AddForce(_rigidbodyTekSettings.JumpForce, ForceMode.Impulse);
            }
        }
    }
}