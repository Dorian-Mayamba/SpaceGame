using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollisions : MonoBehaviour
{
    public int lives;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    //TODO: Fix collisions
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Asteroid"){
            lives--;
            Debug.Log("Ouch!");
        }    
    }
}
