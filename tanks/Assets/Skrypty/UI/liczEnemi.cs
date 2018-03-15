using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class liczEnemi : MonoBehaviour {

    public Image i1;
    public Image i2;
    public Image i3;
    public Image i4;
    public Color c = Color.gray;

    public void Del ()
    {
		if(i1.color!=c)
        {
            i1.color = c;
        }
        else if (i2.color != c)
        {
            i2.color = c;
        }
        else if (i3.color != c)
        {
            i3.color = c;
        }
        else if (i4.color != c)
        {
            i4.color = c;
        }
    }
	
	
}
