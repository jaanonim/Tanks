using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class test2 : MonoBehaviour {

	public Transform target;
    public Transform dol;
    public int zycieEnemi = 50;
    public Slider s;

    void Update () {

        transform.position = dol.position + new Vector3(0, 1f, 0);
        s.value = zycieEnemi;
        transform.LookAt(target);
        float x=dol.eulerAngles.x;
        float z = dol.eulerAngles.z;
        float y = transform.eulerAngles.y;
        transform.rotation = Quaternion.Euler(x, y, z);
        if (zycieEnemi<=0)
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
