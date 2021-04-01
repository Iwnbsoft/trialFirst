using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using topDownShooter.Shooting;

namespace topDownShooter.Camera
{
    public class CameraController : MonoBehaviour
    {
       [SerializeField] private CameraSettings _cameraSettings;
       [SerializeField] private Transform _targetTransform;
       [SerializeField] private Transform _cameraTransform;
       public ShootingManager _ShootingManager;

       private void Update()
       {
          CameraRotationFollow();
          //CameraMovementFollow();
          if (Input.GetKeyDown(KeyCode.Space))
          {
              Debug.Log("try shoot");
              _ShootingManager.Shoot(_cameraTransform.position, _cameraTransform.forward);
          }
       }

       private void CameraRotationFollow()
       {
           _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, 
               Quaternion.LookRotation(_targetTransform.position- _cameraTransform.position), 
               Time.deltaTime * _cameraSettings.RotationLerpSpeed);
       }

       private void CameraMovementFollow()
       {
           _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, 
               _targetTransform.position + _cameraSettings.PositionOffSet, 
               Time.deltaTime * _cameraSettings.PositionLerp );
       }
    }    
}
