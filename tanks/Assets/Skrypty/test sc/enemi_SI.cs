using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemi_SI : MonoBehaviour {

    public float walkSpeed = 300.0f;
    public float attackDistance = 10.0f;
    public Rigidbody r;
    public bool first = true;
	public float last;
	Quaternion last_rotation;
    // Use this for initialization
    void Start () {
		last=transform.rotation.eulerAngles.y;
		last_rotation = transform.rotation;
	}

	// Update is called once per frame
	void Update () {
		
		/*if (Mathf.Abs(last - transform.rotation.y) > 10.0f)
		{
			last_rotation = transform.rotation;
			last=transform.rotation.y;
			Vector3 a = last_rotation * Vector3.left ;
			r.AddForce(a * (walkSpeed * 0.90f) * Time.deltaTime );
		}*/
		r.AddForce(Vector3.left * (walkSpeed * 0.90f) * Time.deltaTime );
	}

    void OnTriggerStay(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
			
            Quaternion targetRotation = Quaternion.LookRotation(other.transform.position - transform.position);
            float oryginalX = transform.rotation.x;
            float oryginalZ = transform.rotation.z;

            Quaternion finalRotation = Quaternion.Slerp(transform.rotation, targetRotation, 5.0f * Time.deltaTime);
            finalRotation.x = oryginalX;
            finalRotation.z = oryginalZ;
            transform.rotation = finalRotation;

            float distance = Vector3.Distance(transform.position, other.transform.position);
            if (distance > attackDistance)
            {
                if (first)
                {
                    r.AddForce(Vector3.right * walkSpeed * Time.deltaTime * 10.0f);
                    first=false;
                }
                else
                {
                    r.AddForce(Vector3.right * walkSpeed * Time.deltaTime);

                }
            }
            else
            {
                first = true;
				r.AddForce(Vector3.left * Time.deltaTime * (walkSpeed/2));
            }

        }
    }
}
