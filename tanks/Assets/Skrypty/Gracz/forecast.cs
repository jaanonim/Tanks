using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forecast : MonoBehaviour {

    
    public Rigidbody r;
    public Vector3 v;
    public GameObject o;
    public int liczba;
    public Vector3 a;

    



    public static Vector3 Plot(Rigidbody rigidbody, Vector3 pos, Vector3 velocity, int steps)
    {
        RaycastHit hit1;
        Vector3 newDir = Vector3.up;
        float distans;

        Vector3[] results = new Vector3[steps];

        float timestep = Time.fixedDeltaTime / Physics2D.velocityIterations ;
        Vector3 gravityAccel = Physics.gravity  * timestep * timestep;
        float drag = 1f - timestep * rigidbody.drag ;
        Vector3 moveStep = velocity  * timestep;

        for (int i = 0; i < steps; ++i)
        {
            moveStep += gravityAccel;
            moveStep *= drag;
            pos += moveStep;
            results[i] = pos;

            if (i > 0)
            {
                distans = Vector3.Distance(results[i - 1], results[i]);
                Vector3 targetDir = results[i - 1] - results[i];
                float step = 1000f * Time.deltaTime;
                newDir = Vector3.RotateTowards(Vector3.forward, targetDir, step, 0.0f);
               

                if (Physics.Raycast(pos, newDir, out hit1, distans))
                {
                   
                    return results[i];
                   
                }
            }
        }
        return Vector3.zero;

    }

    
    void test () {

        a = Plot(r, transform.position, v, liczba);
       /* for (int i = 0; i < liczba; i++)
        {
            Destroy(Instantiate(o, a[i], transform.rotation), 1);
        }  */
        Destroy(Instantiate(o, a, transform.rotation), 1);


    }
	
	
	void Update () {

        v=transform.rotation * Vector3.up * 5000;
        test();
    }


}
