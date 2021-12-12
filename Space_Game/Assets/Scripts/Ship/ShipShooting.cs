using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    public float damage = 10f, range = 100f;
    public Camera shipCam;
    public ParticleSystem muzzleFlash;
    public int score, ammo;

    void Start(){
        score = 0;
        ammo = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }   

        if(Input.GetKeyDown(KeyCode.R)){
            ammo = 10;
        }
    }

    void Shoot(){
        if(ammo > 0){
            muzzleFlash.Play();
            RaycastHit hit;
            if(Physics.Raycast(shipCam.transform.position, shipCam.transform.forward, out hit, range)){
                Debug.Log(hit.transform.name);

                Target target = hit.transform.GetComponent<Target>();

                if(target != null) target.TakeDamage(damage);
            };
            ammo--;
        }
    }

    public void increaseScore(int num){
        score += num;
    }
}
