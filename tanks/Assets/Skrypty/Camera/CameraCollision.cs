using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour {

	public float minDistance ;
	public float maxDistance ;
	public float smooth = 10.0f;
	Vector3 dollyDir;
	public Vector3 dollyDirAdjusted;
	public float distance;
    public float dystans=15;

	// Use this for initialization
	void Awake () {
		dollyDir = transform.localPosition.normalized;
		distance = transform.localPosition.magnitude;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.mouseScrollDelta.y < 0)
        {
            if (dystans < 30)
            {
                dystans += 5;
            }
        }
        else if (Input.mouseScrollDelta.y > 0)
        {
            if (dystans > 0)
            {
                dystans -= 5;
            }
        }
        maxDistance=dystans*2;
        minDistance = dystans;

        Vector3 desiredCameraPos = transform.parent.TransformPoint (dollyDir * maxDistance);
		RaycastHit hit;

		if (Physics.Linecast (transform.parent.position, desiredCameraPos, out hit)) {
			distance = Mathf.Clamp ((hit.distance * 0.87f), minDistance, maxDistance);
				
	    } else
        {
			distance = maxDistance;
		}

		transform.localPosition = Vector3.Lerp (transform.localPosition, dollyDir * distance, Time.deltaTime * smooth);
	}
}
