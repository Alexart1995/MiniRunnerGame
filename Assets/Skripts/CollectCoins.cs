using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    public GameObject coinEffect;
    private GameManager gameManager;

    void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            gameManager.IncreaseScore();
            other.gameObject.SetActive(false);
            GameObject g = Instantiate(coinEffect, transform.position, Quaternion.identity);
            Destroy(g, 2.0f);
        }
    }
}
