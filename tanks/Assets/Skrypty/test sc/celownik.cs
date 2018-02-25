using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celownik : MonoBehaviour
{

    public GameObject target;

    private void Start()
    {
        target = GameObject.Find("celownik");
    }


    // Use this for initialization
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(transform.position);
        target.SendMessage("Move", transform.position);
        Destroy(gameObject);
        
    }

    
}