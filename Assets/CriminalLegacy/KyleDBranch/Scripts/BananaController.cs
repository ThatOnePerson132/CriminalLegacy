using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BananaController : MonoBehaviour
{
    public GameManager gm;


    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gm.bananasCollected++;
            Destroy(gameObject);
        }

    }
}
