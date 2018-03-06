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
        target=t.position;
        agent.SetDestination(target);
	}
	
}
