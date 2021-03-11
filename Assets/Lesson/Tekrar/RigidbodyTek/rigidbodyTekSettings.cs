using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Derslerr
{
    [CreateAssetMenu(menuName = "Derslerrrr/jumpForceSettings")]
public class rigidbodyTekSettings : ScriptableObject
{
 [SerializeField] private Vector3 _jumpForce;
 
 public Vector3 JumpForce { get {
  return _jumpForce;
 }}
 
}
}