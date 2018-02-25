using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class loadscene : MonoBehaviour {

    public GameObject screan;
    public Slider slider;
    public Text text;
	
	public void loadlewel (string name)
    {
        StartCoroutine(LoadAsynchronusly(name));
	}

     IEnumerator LoadAsynchronusly (string name)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(name);

        screan.SetActive(true);


        while(!op.isDone)
        {
            float progress = Mathf.Clamp01(op.progress / .9f);

            slider.value = progress;
            text.text = Mathf.Round(progress * 100) + "%";

            yield return null;

        }
    }
}
