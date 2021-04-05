using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.PlayerControls
{
[CreateAssetMenu(menuName = "topDown Shooter/Player/Movement Settings")]
public class PlayerMovementSettings : ScriptableObject
{
    public float HorizontalSpeed = 5;
    public float VerticalSpeed = 5;
}    
}
