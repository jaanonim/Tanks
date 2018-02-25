using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparks : MonoBehaviour {

    public Transform target;

    void Start()
    {
        target = transform.Find("lufa");
    }


    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
