using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;


public class Settings : MonoBehaviour {

    public AudioMixer mixer;


    public Dropdown rd;

    Resolution[] r;

    public void Start()
    {
        r = Screen.resolutions;

        rd.ClearOptions();

        List<string> op = new List<string>();

        int index = 0;
        for(int i=0; i<r.Length; i++)
        {
            string ops = r[i].width + "x" + r[i].height;
            op.Add(ops);

            if (r[i].width == Screen.currentResolution.width && r[i].height == Screen.currentResolution.height)
            {
                index = i;
            }
        }

        rd.AddOptions(op);
        rd.value = index;
        rd.RefreshShownValue();
    }

    public void screan(int index)
    {
        Resolution ra = r[index];
        Screen.SetResolution(ra.width,ra.height, Screen.fullScreen);
    }

    public void Volume (float v)
    {
        mixer.SetFloat("v",v);
	}

    public void Qality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void full(bool f)
    {
        Screen.fullScreen = f;
    }

    public void x()
    {
        gameObject.SetActive(false);
    }
}
