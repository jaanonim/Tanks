using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celownikP : MonoBehaviour {

    public Transform cel;
    public Camera kamera;
    public float spead = 0.1f;
    public Vector3 pos=Vector3.zero;


    void Start()
    {
        StartCoroutine(LateStart(1));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        kamera = GameObject.Find("Main Camera").GetComponent<Camera>() as Camera;
    }

    // Update is called once per frame
    void Update () {
        //transform.LookAt(cam);
        Move();
    }

    public void Move()
    {
        //pos = Vector3.Lerp(transform.position, pos, spead);
        pos = cel.transform.position;
        Vector3 end = kamera.WorldToScreenPoint(pos);
        transform.position = end;
        
    }
}
