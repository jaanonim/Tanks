using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test3 : MonoBehaviour {

    public Transform target;

    void Start()
    {
        StartCoroutine(LateStart(1));
    }

    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        target = GameObject.Find("tank").transform;
    }

    // Update is called once per frame
    void Update () {
        transform.LookAt(target);
	}
}
