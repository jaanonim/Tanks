using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test4 : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start () {
        target = GameObject.Find("tank").transform;
    }
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(target);
    }
}
