using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter
{
public class ManagerInitializerMono : MonoBehaviour
{
    [SerializeField] private AbstractScriptableManagerBase[] _abstractScriptableManagerArray;
    private List<AbstractScriptableManagerBase> _instantiatedScriptableManagerList;

    private void Start()
    {
        _instantiatedScriptableManagerList = new List<AbstractScriptableManagerBase>(_abstractScriptableManagerArray.Length);
        for (int i = 0; i < _abstractScriptableManagerArray.Length; i++)
        {
            var instantiated = Instantiate(_abstractScriptableManagerArray[i]);
            instantiated.Initialize();
            _instantiatedScriptableManagerList.Add(instantiated);
        }
    }

    private void OnDestroy()
    {
        if (_instantiatedScriptableManagerList != null)
        {
                for (int i = 0; i < _instantiatedScriptableManagerList.Count; i++)
                {
                 _instantiatedScriptableManagerList[i].Destroy();
                }
        
        }
    }
}
}
