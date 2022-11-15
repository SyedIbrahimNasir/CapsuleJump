using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingInstantiate : MonoBehaviour
{

    public Rigidbody projectile;
    public Transform barrelEnd;
      
    
    void Update()
    {
        if (!ControlFreak2.CF2Input.GetButtonDown("Fire1"))
        {
            return;
        }
        Rigidbody projectileInstance;
        projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
        projectileInstance.AddForce(barrelEnd.up * 500f);


    }
}
