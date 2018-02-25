using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class button : MonoBehaviour {

    public Button yourButton;

    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Exit");
            Application.Quit();
        }
    }

}
