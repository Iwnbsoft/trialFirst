using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter
{
    [CreateAssetMenu(menuName = "topDown Shooter/Camera/Camera Settings")]
public class CameraSettings : ScriptableObject
{ 
    [Header("Rotation")]
   [SerializeField] private float _rotationLerpSpeed = 1;
   public float RotationLerpSpeed
   {
       get { return _rotationLerpSpeed; }
   }
   
    [Header("Position")]
   [SerializeField] private float _positionLerp = 1;
   public float PositionLerp
   {
       get { return _positionLerp; }
   }
   [SerializeField] private Vector3 _positionOffset;
   public Vector3 PositionOffSet
   {
       get { return _positionOffset; }
   }
}    
}
