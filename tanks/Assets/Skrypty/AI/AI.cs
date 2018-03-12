using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour {

    public NavMeshAgent agent;
    public Transform t;
    public Vector3 target;

    // Use this for initialization
    void Update () {
        //target = transform.position + Vector3.forward * 100;
         

        if (Vector3.Distance(target, t.position) > 3.0f)
        {
            target = t.position;
            agent.SetDestination(target);
        }

    }


}
