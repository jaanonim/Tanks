using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zycie : MonoBehaviour {


    public float currentHealth = 100.0f;
    private float maxHealth = 100.0f;
    public GameObject licznik;
    public Slider s;

    private void Start()
    {
        currentHealth = maxHealth;
        s = GameObject.Find("live").GetComponent<Slider>() as Slider;
    }

    private void OnTriggerEnter(Collider collision)
    {

        s.value = currentHealth;

        if (collision.tag=="pociske")
        {
            //collision.gameObject;
            currentHealth = currentHealth - 10;
            if(currentHealth<0)
            {
                currentHealth = 0;
                
            }
            if(currentHealth==0)
            {
                licznik.SendMessage("Defend");
            }

        }
    }

}
