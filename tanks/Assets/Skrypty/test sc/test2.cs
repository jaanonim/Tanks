﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour {

	public Transform target;
    public int zycieEnemi = 50;
    public Slider s;

    void Update () {

        s.value = zycieEnemi;
        transform.LookAt(target);
        if(zycieEnemi<=0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="pocisk")
        {
            zycieEnemi = zycieEnemi - 10;
        }
    }
}
