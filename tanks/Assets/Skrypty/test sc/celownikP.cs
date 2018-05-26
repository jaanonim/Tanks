using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celownikP : MonoBehaviour {

    public Transform cam;
    public Camera kamera;
    public float spead = 0.1f;
    public Vector3 pos=Vector3.zero;
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(cam);
        Move();
    }

    public void Move()
    {
        //pos = Vector3.Lerp(transform.position, pos, spead);
        pos = cam.transform.position;
        Vector3 end = kamera.WorldToScreenPoint(pos);
        transform.position = end;
        
    }
}
