﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    
    public Transform target;
    public Transform tank;
    public float myszGoraDol = 0.0f;
    public float myszLewoPrawo = 0.0f;
    public float czuloscMyszki = 3.0f;
    public float dystans = 15;
    private float rotx = 0.0f;
    private float roty = 0.0f;
    public bool kolizja;
    public float late;
    public float late2;
    private float offset;
    public float speadRot = 100;
    public float s = 0.5f;

    public float rotX
    {
        get { return target.rotation.eulerAngles.x; }
        set
        {
            Vector3 v = target.rotation.eulerAngles;
            target.rotation = Quaternion.Euler(value, v.y, v.z);
        }
    }
    public float rotY
    {
        get { return target.rotation.eulerAngles.y; }
        set
        {
            Vector3 v = target.rotation.eulerAngles;
            target.rotation = Quaternion.Euler(v.x, value, v.z);
        }
    }

    private void Update()
    {
        late2 += Time.deltaTime;

        if (kolizja)
        {
            if (!(late - target.rotation.eulerAngles.x >= 0))
            {
                kolizja = false;
            }
        }
    }

    public void LateUpdate()
    {
     
        target.position = tank.position + new Vector3(0, 1.57f, 0);
        //target.rotation = tank.rotation;
        myszGoraDol += Input.GetAxis("Mouse Y") * czuloscMyszki *Time.deltaTime *speadRot;
        myszLewoPrawo += Input.GetAxis("Mouse X") * czuloscMyszki * Time.deltaTime * speadRot;
        roty = myszLewoPrawo;
        rotx = -myszGoraDol;

        if (Input.mouseScrollDelta.y < 0)
        {
            if (dystans < 30)
            {
                dystans += 5;
            }
        }
        else if (Input.mouseScrollDelta.y > 0)
        {
            if (dystans > 0)
            {
                dystans -= 5;
            }
        }



        Vector3 d = target.position + (target.rotation * new Vector3(0, 0, - dystans));
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

        if(kolizja)
        {
            rotX = rotx;
        }
        else
        {
            rotX = rotx;
        }
        rotY = roty;

        late = target.rotation.eulerAngles.x;



    }
    private void OnTriggerEnter(Collider other)
    {
        kolizja = true;
    }


    
    private void OnTriggerExit(Collider other)
    {
        kolizja = false;
    }

}