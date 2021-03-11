using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dersler
{
    public class rotateO : MonoBehaviour
    {
        [SerializeField] private rotateSet _rotateSet;

        private void Update()
        {
            transform.Rotate(Vector3.up, _rotateSet.Speed * Time.deltaTime);
        }
    }
    
}