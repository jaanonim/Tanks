using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public float CameraMoveSpeed = 120.0f;
	public Transform target;

	public float clampAngle = 90.0f;
	public float MouseSpead = 3.0f;


	public float mouseX;
	public float mouseY;

	private float rotY = 0.0f;
	private float rotX = 0.0f;



	// Use this for initialization
	void Start () {
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;
	}
	
	// Update is called once per frame
	void Update () {

		// We setup the rotation of the sticks here
	
		mouseX = Input.GetAxis ("Mouse X");
		mouseY = Input.GetAxis ("Mouse Y");

		rotY += mouseX * MouseSpead * 100 * Time.deltaTime;
		rotX += mouseY * MouseSpead * 100 * Time.deltaTime;

		rotX = Mathf.Clamp (rotX, -clampAngle, clampAngle);

		Quaternion rotation = Quaternion.Euler (rotX, rotY, 0.0f);
		transform.rotation = rotation;


	}

	void LateUpdate ()
    {
	

		float step = CameraMoveSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, target.position + new Vector3(0, 1.57f, 0), step);
	}
}
