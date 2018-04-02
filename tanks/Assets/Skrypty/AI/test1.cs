using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour {

    public GameObject gora;

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pocisk")
        {
            gora.SendMessage("Hit", other);
        }
    }

}
