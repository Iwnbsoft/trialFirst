using System.Collections;
using System.Collections.Generic;
using topDownShooter.PlayerInput;
using UnityEngine;


namespace TopDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "Topdown Shooter/Input/Player Input Data")]
    public class InputData : AbstractInputData
    {
        [Header("Axis Base Control")]
        [SerializeField] private bool _axisActive;
        [SerializeField] private string AxisNameHorizontal;
        [SerializeField] private string AxisNameVertical;

        [Header("Key Base Control")]
        [SerializeField] private bool _keyBaseHorizontalActive;
        [SerializeField] private KeyCode PositiveHorizontalKeyCode;
        [SerializeField] private KeyCode NegativeHorizontalKeyCode;
        [SerializeField] private bool _keyBaseVerticalActive;
        [SerializeField] private KeyCode PositiveVerticalKeyCode;
        [SerializeField] private KeyCode NegativeVerticalKeyCode;
        [SerializeField] private float _increaseAmount = 0.015f;

        public override void ProcessInput()
        {
            if (_axisActive)
            {
                Horizontal = Input.GetAxis(AxisNameHorizontal);
                Vertical = Input.GetAxis(AxisNameVertical);
            }
            else
            {
                if (_keyBaseHorizontalActive)
                {
                    KeyBaseAxisControl(ref Horizontal, PositiveHorizontalKeyCode, NegativeHorizontalKeyCode);
                }
                if (_keyBaseVerticalActive)
                {
                    KeyBaseAxisControl(ref Vertical, PositiveVerticalKeyCode, NegativeVerticalKeyCode);
                }
            }
        }

        private void KeyBaseAxisControl(ref float value, KeyCode positive, KeyCode negative)
        {
            bool positiveActive = Input.GetKey(positive);
            bool negativeActive = Input.GetKey(negative);
            if (positiveActive)
            {
                value += _increaseAmount;
            }
            else if (negativeActive)
            {
                value -= _increaseAmount;
            }
            else
            {
                value = 0;
            }

            value = Mathf.Clamp(value, -1, 1);
        }


    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.PlayerInput
{
    [CreateAssetMenu(menuName = "topDown Shooter/Input/Input Data")]
public class InputData : ScriptableObject
{
    public float Horizontal;
    public float Vertical;

    [Header("Axis Base Control")] 
    [SerializeField] private bool _axisActive;
    [SerializeField] private string AxisNameHorizontal;
    [SerializeField] private string AxisNameVeritcal;

    [Header("Key Base Control")] 
    [SerializeField] private bool _keyBaseHorizontalActive;
    [SerializeField] private KeyCode positiveHorizontalKeyCode;
    [SerializeField] private KeyCode negativeHorizontalKeyCode;
    
    [SerializeField] private bool _keyBaseVerticalActive;
    [SerializeField] private KeyCode positiveVerticalKeyCode;
    [SerializeField] private KeyCode negativeVerticalKeyCode;

    [SerializeField] private float _increaseAmount = 0.015f;

    public void ProcessInput()
    {
        if (_axisActive)
        {
            Horizontal = Input.GetAxis(AxisNameHorizontal);
            Vertical = Input.GetAxis(AxisNameVeritcal);
        }
        else
        {
            if (_keyBaseHorizontalActive)
            {
                KeyBaseAxisControl(ref Horizontal, positiveHorizontalKeyCode, negativeHorizontalKeyCode);
            }

            if (_keyBaseVerticalActive)
            {
                KeyBaseAxisControl(ref Vertical, positiveVerticalKeyCode, negativeVerticalKeyCode);
            }
        }
    }

    private void KeyBaseAxisControl(ref float value, KeyCode positive, KeyCode negative)
    {
        bool positiveActive = Input.GetKey(positive);
        bool negativeActive = Input.GetKey(negative);

        if (positiveActive)
        {
            value += _increaseAmount;
            //value = Mathf.Lerp(value, 1, Time.time * _increaseAmount);
        }
        else if (negativeActive)
        {
            value -= _increaseAmount;
            //value = Mathf.Lerp(value, -1, Time.time * _increaseAmount);
        }
        else
        {
            value = 0;
            //value = Mathf.Lerp(value, 0, Time.time * _increaseAmount);
        }
    }
    



}
}

*/
