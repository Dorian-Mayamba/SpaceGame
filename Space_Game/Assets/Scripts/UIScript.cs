using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public GameObject player;
    public Text healthText;
    public Text ammoText;
    public Text scoreText;

    private int lives;
    private int currentScore;
    private int ammo;

    // Update is called once per frame
    void Update()
    {
        lives = player.GetComponent<ShipCollisions>().lives;
        ammo = player.GetComponent<ShipShooting>().ammo;
        currentScore = player.GetComponent<ShipShooting>().score;; 

        healthText.text = "Lives: "+lives+"/3";
        scoreText.text = "Score: "+currentScore;
        ammoText.text = "Ammo: "+ammo+"/10";
    }
}
