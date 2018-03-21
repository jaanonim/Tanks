using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform t;
    public Transform a;

    public Vector3 target;

    public float rotY
    {
        get { return transform.rotation.eulerAngles.y; }
        set
        {
            Vector3 v = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(v.x, value, v.z);
        }
    }

    // Use this for initialization
    void Update () {
        //target = transform.position + Vector3.forward * 100;
         

        if (Vector3.Distance(target, t.position) > 3.0f)
        {
            target = t.position;
            agent.SetDestination(target);
        }

        rotY= a.eulerAngles.y;

        transform.position=a.position;

    }


}
