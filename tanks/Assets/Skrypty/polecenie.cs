using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class polecenie : MonoBehaviour {

    float timer;
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        if(timer>4)
        {
            Destroy(gameObject);
        }
    }
}
