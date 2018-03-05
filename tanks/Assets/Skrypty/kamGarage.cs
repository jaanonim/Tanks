using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamGarage : MonoBehaviour {

    public Transform target;
    public float myszLewoPrawo = 0.0f;
    public float czuloscMyszki = 3.0f;
    private float roty = 0.0f;
    private float late=0.0f;

   
    public float rotY
    {
        get { return target.rotation.eulerAngles.y; }
        set
        {
            Vector3 v = target.rotation.eulerAngles;
            target.rotation = Quaternion.Euler(v.x, value, v.z);
        }
    }


    public void LateUpdate()
    {

        myszLewoPrawo += Input.GetAxis("Mouse X") * czuloscMyszki;

        if (Input.GetButton("Fire1"))
        {
             
            roty = myszLewoPrawo + late;


            rotY = roty;
           

        }
        if (Input.GetButtonUp("Fire1"))
        {
            late = myszLewoPrawo;
        }
    }

}
