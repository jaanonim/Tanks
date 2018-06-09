using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class garageLight : MonoBehaviour {

    public GameObject g;
    public GameObject o;

    // Update is called once per frame
    void Update()
    {
        if (0 == Random.Range(0, 11))
        {
            g.SetActive(false);
            o.SetActive(true);
        }
        else
        {
            g.SetActive(true);
            o.SetActive(false);
        }

    }
}
