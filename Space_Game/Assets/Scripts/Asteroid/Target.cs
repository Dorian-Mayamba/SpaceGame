using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public GameObject player;

    void Start() {
        player = GameObject.FindWithTag("Player");    
    }

    public void TakeDamage(float damage){
        health -= damage;

        if(health <= 0f){
            Die();
        }
    }

    void Die (){
        Destroy(gameObject);
        player.GetComponent<ShipShooting>().increaseScore(500);
    }

}
