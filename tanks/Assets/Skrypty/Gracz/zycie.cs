using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zycie : MonoBehaviour {

    public zmienne dane;
    private float maxHealth;
    public float currentHealth;
    
    public GameObject licznik;
    public Slider s;

    private void Start()
    {
        maxHealth = dane.myHealth;
        currentHealth = maxHealth;
        s = GameObject.Find("live").GetComponent<Slider>() as Slider;
        licznik = GameObject.Find("licznik");
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
