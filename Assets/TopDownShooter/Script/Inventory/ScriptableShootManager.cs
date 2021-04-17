using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Inventory
{
    [CreateAssetMenu(menuName = "topDown Shooter/Inventory/Scriptable Shoot Manager")]
public class ScriptableShootManager : AbstractScriptableManager<ScriptableShootManager>
{
    public override void Initialize()
    {
        base.Initialize();
        Debug.Log("scriptable shoot manager activated");
    }

    public override void Destroy()
    {
        base.Destroy();
        Debug.Log("scriptable shoot manager destroyed");
    }

    public void Shoot()
    {
        
    }
}
}
