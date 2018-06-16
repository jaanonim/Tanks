using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public Rigidbody bullet;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        RaycastHit hit1;

        if (timer > 4)
        {
            if (Physics.Raycast(transform.position - new Vector3(0, .2f,0), transform.TransformDirection(Vector3.forward), out hit1, 20))
            {            
                if (hit1.collider.gameObject.tag=="Player")
                {
                    Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                    Vector3 fwd = transform.TransformDirection(Vector3.forward);
                    clone.AddForce(fwd * 1500f);
                    timer = 0;
                }
               
            }
            
        } 

    }
}
