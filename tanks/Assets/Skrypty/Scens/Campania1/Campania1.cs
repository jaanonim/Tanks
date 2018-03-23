using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campania1 : MonoBehaviour {

    public GameObject control;

    public Transform player;
    public Table[] enemi;


    // Use this for initialization
    void Start ()
    {
        control.SendMessage("SpawnPlayer",player);

        foreach(Table i in enemi)
        {
            control.SendMessage("SpawnEnemi", i);
        }
        
    }
	
}
