using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

    public GameObject player;
	
	public void SpawnPlayer (Transform t)
    {
        Vector3 pozycja = t.position;
        Quaternion rotacja = t.rotation;

        Instantiate(player, pozycja, rotacja);
    }

    public void SpawnEnemi(Table table)
    {
        Transform t = table.spawn;
        Vector3 pozycja = t.position;
        Quaternion rotacja = t.rotation;

        Instantiate(table.prefab, pozycja, rotacja);
    }


}
