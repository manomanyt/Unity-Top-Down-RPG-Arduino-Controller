using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UI;

public class SwordChestTrigger : MonoBehaviour
{
    public GameObject SwordUITrue;
    public GameObject ChestOpened;
    public GameObject ChestClosed;
    public GameObject Player;
    void Start()
    {
        
    }

    void Update()
    {

    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SwordUITrue.SetActive(true);
            GameObject.Find("Player").GetComponent<AttackScript>().enabled = true;
            ChestOpened.SetActive(true);
            ChestClosed.SetActive(false);
        }
    }
}
