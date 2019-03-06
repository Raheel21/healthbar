using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private Stat health;


    private void Awake()
    {

        health.Initialize();

    }


    void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            health.CurrentVal -= 10;
            Debug.Log("hits");

        }
    }
}
