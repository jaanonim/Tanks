using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour {

	public Transform target;
    public GameObject G;
    public GameObject licznik;
    public Transform dol;
    public int zycieEnemi = 50;
    public Slider s;


    void Update () {

        
        //transform.position = dol.position + new Vector3(0, 1f, 0);
        s.value = zycieEnemi;


        float y = target.eulerAngles.x;
        float x = transform.eulerAngles.x;
        float z = transform.eulerAngles.z;
        transform.rotation = Quaternion.Euler(x, y, z);

        if (zycieEnemi<=0)
        {
            licznik.SendMessage("Enemi");
            Destroy(G);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        Hit(other);
    }

    public void Hit(Collider other)
    {
        if (other.tag == "pocisk")
        {
            zycieEnemi = zycieEnemi - 10;
        }
    }
}
