using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class lufa : MonoBehaviour {

	public Transform target;
        
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = target.position;
		transform.rotation = target.rotation;
    }
}
