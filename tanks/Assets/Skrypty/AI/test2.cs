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

    public float rotY
    {
        get { return transform.rotation.eulerAngles.y; }
        set
        {
            Vector3 v = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(v.x, value, v.z);

        }
    }


    void LateUpdate () {

        transform.rotation = dol.rotation;

        rotY = target.eulerAngles.y;

        transform.position = dol.position + new Vector3(0, 1f, 0);
        s.value = zycieEnemi;

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
