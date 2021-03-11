using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Dersler
{
    [CreateAssetMenu(menuName = "Dersler/Dersler1/tekrarRotateSet")]
public class rotateSet : ScriptableObject
{
    [SerializeField] private float _speed = 1;
    
    public float Speed
    {
        get { return _speed; }
    }
}
}