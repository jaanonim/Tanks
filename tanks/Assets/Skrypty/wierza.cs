using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wierza : MonoBehaviour {

    public Transform gracz;


    
    public float myszLewoPrawo = 0.0f;
    public float czuloscMyszki = 3.0f;
    public float x;
    public float z;
    public Rigidbody m_Rigidbody;
    private float obrut;

    void LateUpdate()
    {
		myszLewoPrawo += Input.GetAxis("Mouse X") * czuloscMyszki;
        /*obrut = (myszLewoPrawo + 90f + gracz.eulerAngles.y) / 2;
        Vector3 a = Vector3.Lerp(new Vector3(myszLewoPrawo +90, 0, 0), new Vector3(gracz.eulerAngles.y, 0, 0), 0.1f);
        obrut = a.x;*/
        obrut = myszLewoPrawo + 90f;



        x = transform.eulerAngles.x;
        z = transform.eulerAngles.z;
        transform.rotation = Quaternion.Euler(x, obrut, z);
    }

}