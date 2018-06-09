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
            if(Physics.Raycast(transform.position, Vector3.up, out hit1, 20))
            {
                Debug.Log(hit1.collider.gameObject.tag);
                if(hit1.collider.gameObject.tag=="Player")
                {
                    Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                    Vector3 fwd = transform.TransformDirection(Vector3.down);
                    clone.AddForce(fwd * 1500f);
                    timer = 0;
                }
               
            }
            
        } 

    }
}
