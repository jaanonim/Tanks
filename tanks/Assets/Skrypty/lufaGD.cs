using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lufaGD : MonoBehaviour {

    public float myszGoraDol = 0.0f;
    public float czuloscMyszki = 3.0f;
    public float zakresMyszyGoraDol = 15.0f;

    
	void LateUpdate () {
        myszGoraDol += Input.GetAxis("Mouse Y") * czuloscMyszki;
        myszGoraDol = Mathf.Clamp(myszGoraDol, 0, zakresMyszyGoraDol);
        transform.localRotation = Quaternion.Euler(0, 2, -myszGoraDol);
    }
}
