using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class strzelanie : MonoBehaviour {

    public Rigidbody bullet;
    public new AudioSource audio;
    float timer;
    bool fire=false;
    public GameObject sparks;
    public Text text2;
    public Slider slider1;
    public Transform bulletP;
    public Color start = Color.red;
    public Color end = Color.green;
    public Image Img;
    public float TimeReload=3.0f;
    public Rigidbody test1;
    //public GameObject pause;
    
    void Start()
    {
        text2 = GameObject.Find("time").GetComponent<Text>() as Text;
        text2.enabled = true;
        slider1 = GameObject.Find("reload").GetComponent<Slider>() as Slider;
        Img = GameObject.Find("FillR").GetComponent<Image>() as Image;
    }

    void Update()
    {
        //test();

        timer += Time.deltaTime;
        float a = 4-timer;
        if(fire)
        {
            text2.text = "0.00";
        }
        else
        {
            text2.text = a.ToString();
        }
        
        slider1.value = timer;
        Color c = Color.Lerp(start, end, timer / 4);
        Img.color = c;
        text2.color = c;

        if (Input.GetButtonDown("Fire1") && fire && !pause.IsPause)
        {
            audio.Play();
            GameObject go;
            go = Instantiate(sparks, transform.position + new Vector3(0, 0.1f, 0), transform.rotation) as GameObject;
            Rigidbody clone = Instantiate(bullet, bulletP.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.up);
            clone.AddForce(fwd * 5000f);
            fire = false;
            timer = 0;
            Destroy(go, 2);


        }
        if(!fire && timer > TimeReload)
        {
            fire = true;
        }
    }

    void test()
    {
        Rigidbody prub = Instantiate(test1, bulletP.position, transform.rotation) as Rigidbody;
        Vector3 f = transform.TransformDirection(Vector3.up);
        prub.AddForce(f* 5000f);
    }

  
}
