using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public Rigidbody bullet;
    float timer;


    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 4)
        {
            Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.down);
            clone.AddForce(fwd * 1500f);
            timer = 0;
        } 

    }
}
