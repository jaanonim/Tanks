using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class znikanie : MonoBehaviour {

    public GameObject bulletHole;
    public GameObject bum;
    public GameObject bum_o;
    private float timer = 0.0f;
    private float c_znikanie = 4.0f;
    private Vector3 pozycja;
    private GameObject col;
    bool stop = false;
    public Rigidbody r;
    public Renderer rend;

    private void Start()
    {
        rend.enabled = true;
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > c_znikanie)
        {
            Destroy(gameObject);
            Quaternion a = Quaternion.Euler(Vector3.up);
            wybuch(a,false);

        }
    }


    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Destroy(gameObject,1);
        rend.enabled=false;
        r.velocity = Vector3.zero;
        r.isKinematic = true;
        pozycja = contact.point;
        col = collision.gameObject;

        Quaternion a = Quaternion.FromToRotation(Vector3.up, contact.normal);
        GameObject go;
        if (col.tag != "sciana")
        {
            go = Instantiate(bulletHole, pozycja, a) as GameObject;
            Destroy(go, 7);
        }
        
        wybuch(a, true);
    
    }

    void wybuch(Quaternion a,bool t)
    {
        if(t)
        {
            GameObject goes;

            if (col.tag=="sciana")
            {
                goes = Instantiate(bum_o, pozycja, Quaternion.Euler(Vector3.up)) as GameObject;
            }
            else
            {
                goes = Instantiate(bum, transform.position, a) as GameObject;
            }
            Destroy(goes, 1);
            
        }
        else
        {
                GameObject go;
                go = Instantiate(bum_o, pozycja, Quaternion.Euler(Vector3.up)) as GameObject;
                Destroy(go, 1);
        }
    }
}
