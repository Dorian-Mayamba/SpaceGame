using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipCollisions : MonoBehaviour
{
    public int lives;
    public GameObject asteroid;
    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Asteroid"){
            lives--;
            Debug.Log("Ouch!");
        }    
    }
}
