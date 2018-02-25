using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beczka : MonoBehaviour {

    public GameObject bum;
    public GameObject del;

    private void OnCollisionEnter(Collision collision)
    {
       if(10000 < (collision.impulse / Time.fixedDeltaTime).magnitude||collision.gameObject.tag=="pocisk")
        {
            GameObject goes;
            goes = Instantiate(bum, transform.position, Quaternion.Euler(Vector3.up)) as GameObject;
            Destroy(goes, 3);
            Destroy(gameObject);
            GameObject go;
            go = Instantiate(del, transform.position+new Vector3(0,3,0), Quaternion.Euler(Vector3.down)) as GameObject;
        }
    }

}
