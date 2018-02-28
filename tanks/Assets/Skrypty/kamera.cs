using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    
    public Transform target;
    public float myszGoraDol = 0.0f;
    public float czuloscMyszki = 3.0f;
    public int dystans = 15;
    private float rotx = 0.0f;
    public bool kolizja;
    public float late;
    public float late2;
    private float offset;

    public float rotX
    {
        get { return target.rotation.eulerAngles.x; }
        set
        {
            Vector3 v = target.rotation.eulerAngles;
            target.rotation = Quaternion.Euler(value, v.y, v.z);
        }
    }

    public void LateUpdate()
    {
        late2 = myszGoraDol;

        myszGoraDol += Input.GetAxis("Mouse Y") * czuloscMyszki;
        

       rotx = -myszGoraDol;

        if (Input.mouseScrollDelta.y > 0)
        {
            if (dystans < 30)
            {
                dystans += 5;
            }
        }
        else if (Input.mouseScrollDelta.y < 0)
        {
            if (dystans > 0)
            {
                dystans -= 5;
            }
        }



        Vector3 d = target.position + (target.rotation * new Vector3(0, 0, -dystans));
        Vector3 end = d;
        transform.position = end;
        //transform.rotation = target.rotation;
        if (dystans != 0)
        {
            transform.LookAt(target);
        } else
        {
            transform.rotation = target.rotation;
        }

       // if (late>0&&)
        //{
            
            rotX = rotx;
          
        //}

    }

    private void OnTriggerEnter(Collider other)
    {
       
        late = myszGoraDol-late2;
    }

    
}