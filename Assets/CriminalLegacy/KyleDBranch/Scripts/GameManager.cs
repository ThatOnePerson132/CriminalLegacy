using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int health;
    public int stamina;
    public int bananasCollected;

    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI staminaDisplay;
    public TextMeshProUGUI bananaMeter;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
