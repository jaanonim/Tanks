using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class licznik : MonoBehaviour {

    public int liczbaEnemi = 4;
    public GameObject end;
    public TextMeshProUGUI text;

    // Update is called once per frame
    void Update () {
		if(liczbaEnemi==0)
        {
            //win !!! :-)
            Time.timeScale = 0.05f;
            end.SetActive(true);
            text.text = "You win !!!";

        }
	}

    public void Enimi()
    {
        liczbaEnemi--;
    }

    public void Defend()
    {
        Time.timeScale = 0.05f;
        end.SetActive(true);
        text.text = "You lost !!!";

    }

    public void Back()
    {
        Time.timeScale = 1f;
    }


}
