using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zycie : MonoBehaviour {


    public float currentHealth = 100.0f;
    private float maxHealth = 100.0f;
    public GameObject licznik;
    public Texture2D healthTexture;

    private void Start()
    {
        currentHealth = 100;
    }

    void OnGUI()
    {
        float hpWidth = (300.0f * currentHealth)/maxHealth;
        GUI.DrawTexture(new Rect(10, Screen.height-25f, hpWidth, 15), healthTexture);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag=="pociske")
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
