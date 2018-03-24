using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m : MonoBehaviour
{
    public GameObject control;

    public Transform player;

    // Use this for initialization
    void Start()
    {
        control.SendMessage("SpawnPlayer", player);
    }

}
