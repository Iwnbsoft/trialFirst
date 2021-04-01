using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace topDownShooter.Shooting
{

public class ShootingManager : MonoBehaviour
{
    public void Shoot(Vector3 from, Vector3 direction) // Shootingleri kontrol etmek için oluşturulan method
    {
        RaycastHit hit;
        bool rayHit = Physics.Raycast(transform.position,direction, out hit, Mathf.Infinity);
        Debug.DrawLine(transform.position, transform.position+ direction*10, Color.blue, 2);
        Debug.DrawRay(transform.position,direction, Color.blue);
        if (rayHit) //Eğer bir obje hit olduysa...
        {
            Debug.Log(hit.collider.name);//Eğer raycast atıldığında çalışırsa, çarpan objenin adını alacak.

            var healthStat = hit.collider.GetComponent<HealthStat>();

            if (healthStat!=null)
            {
                healthStat.Hit(5);
            }
        }
    }
    
}
}
