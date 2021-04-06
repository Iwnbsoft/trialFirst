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
       //public ShootingManager _ShootingManager;

       private void Update()
       {
          CameraRotationFollow();
          CameraMovementFollow();
          //if (Input.GetKeyDown(KeyCode.Space)) { Debug.Log("try shoot"); _ShootingManager.Shoot(_cameraTransform.position, _cameraTransform.forward); }
       }

       private void CameraRotationFollow()
       {
           _cameraTransform.rotation = Quaternion.Lerp(_cameraTransform.rotation, 
               Quaternion.LookRotation(_targetTransform.forward), 
               Time.deltaTime * _cameraSettings.RotationLerpSpeed);
       }

       private void CameraMovementFollow()
       {
           Vector3 offset = (_cameraTransform.right * _cameraSettings.PositionOffSet.x)
                            + (_cameraTransform.up * _cameraSettings.PositionOffSet.y)
                            + (_cameraTransform.forward * _cameraSettings.PositionOffSet.z);

           _cameraTransform.position = Vector3.Lerp(_cameraTransform.position, 
               _targetTransform.position + offset, 
               Time.deltaTime * _cameraSettings.PositionLerp);   
           
       }
    }    
}
