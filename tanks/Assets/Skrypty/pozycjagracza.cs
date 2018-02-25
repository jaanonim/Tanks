using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pozycjagracza : MonoBehaviour {

    public Transform t;
    public Vector3 pozycja;
    public float x;
    public float y;
    public Vector3 end;

    private float teren_x = 500.0f;
    private float teren_y = 500.0f;

    private float plansza_x = 200.0f;
    private float plansza_y = 200.0f;


	// Update is called once per frame
	void Update ()
    {
        pozycja = t.position;
        x = (pozycja.x * plansza_x) / teren_x;
        y = (pozycja.z * plansza_y) / teren_y;
        end = new Vector3 (Screen.width-210.5f+x, y+10.5f ,0.0f);
        transform.position = end;

        float z = t.eulerAngles.y;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, -(z));
    }
    
}
