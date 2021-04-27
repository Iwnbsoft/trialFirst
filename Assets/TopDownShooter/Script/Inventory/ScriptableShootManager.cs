using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using topDownShooter.Stat;

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

    public void Shoot(Vector3 origin, Vector3 direction)
    {
        RaycastHit rHit;
        var physic = Physics.Raycast(origin, direction, out rHit);

        if (physic)
        {
            Debug.Log("Collider : " + rHit.collider.name);
            int colliderInstanceId = rHit.collider.GetInstanceID();
            if (DamagebleHelper.DamagebleList.ContainsKey(colliderInstanceId))
            {
                DamagebleHelper.DamagebleList[colliderInstanceId].Damage(5);
            }
        }
    }
}
}
