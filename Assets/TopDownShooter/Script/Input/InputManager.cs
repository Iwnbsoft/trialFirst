using System.Collections;
using System.Collections.Generic;
using topDownShooter.PlayerInput;
using UnityEngine;

namespace TopDownShooter.PlayerInput
{
    public class InputManager : MonoBehaviour
    {
        [SerializeField] private AbstractInputData[] _inputDataArray;
        private void Update()
        {
            for (int i = 0; i < _inputDataArray.Length; i++)
            {
                _inputDataArray[i].ProcessInput();
            }
        }
    }
}

/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.PlayerInput
{

public class InputManager : MonoBehaviour
{
    //[SerializeField] private InputData _rotationInputData;
    //private Vector3 _lastMouseInput;
    [SerializeField] private InputData[] _inputDataArray;
    private void Update()
    {

        for (int i = 0; i < _inputDataArray.Length; i++)
        {
            _inputDataArray[i].ProcessInput();
        }
        
        /*_inputData.Horizontal = Input.GetAxis("Horizontal");
        _inputData.Vertical = Input.GetAxis("Vertical");
        
        _rotationInputData.Horizontal = (Input.mousePosition.x - _lastMouseInput.x);
        _lastMouseInput = Input.mousePosition;
        
    }
}
}
*/