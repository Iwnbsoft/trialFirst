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
}
}