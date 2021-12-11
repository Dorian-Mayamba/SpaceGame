using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    public float damage = 10f, range = 100f;
    public Camera shipCam;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }   
    }

    void Shoot(){
        RaycastHit hit;
        if(Physics.Raycast(shipCam.transform.position, shipCam.transform.forward, out hit, range)){
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();

            if(target != null) target.TakeDamage(damage);
        };
    }
}
