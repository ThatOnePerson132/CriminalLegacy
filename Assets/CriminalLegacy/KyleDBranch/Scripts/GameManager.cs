using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int ammo;
    public int health;
    public int stamina;
    public int bananasCollected;

    public TextMeshProUGUI ammoDisplay;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI staminaDisplay;
    public TextMeshProUGUI bananaMeter;

    public RawImage stealthIcon;
    public RawImage stealthIcon2;

    public bool isGameActive;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        healthDisplay.text = "Health: " + health + "/100";
        
        stamina = 100;
        staminaDisplay.text = "Stamina: " + stamina + "/100";

        bananasCollected = 0;
        bananaMeter.text = "BananasCollected: " + bananasCollected;

        ammo = 100;
        ammoDisplay.text = "Ammo: " + ammo + "/100";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
