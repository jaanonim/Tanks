using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class gracz1 : MonoBehaviour
{
    public zmienne dane;

    public float m_Speed ;                 // How fast the tank moves forward and back.
    public float m_TurnSpeed ;            // How fast the tank turns in degrees per second.
    public AudioSource m_MovementAudio;         // Reference to the audio source used to play engine sounds. NB: different to the shooting audio source.
    public AudioClip m_EngineIdling;            // Audio to play when the tank isn't moving.
    public AudioClip m_EngineDriving;           // Audio to play when the tank is moving.
    public float m_PitchRange = 0.2f;           // The amount by which the pitch of the engine noises can vary.
    public Rigidbody m_Rigidbody;

    private bool kolizja;
    private string m_MovementAxisName;          // The name of the input axis for moving forward and back.
    private string m_TurnAxisName;              // The name of the input axis for turning.
    private float m_MovementInputValue;         // The current value of the movement input.
    private float m_TurnInputValue;             // The current value of the turn input.
    private float m_OriginalPitch;              // The pitch of the audio source at the start of the scene.
    float spead;
    public TextMeshProUGUI textmeshPro;
    public Slider s;
    private Vector3 lastPosition;
   





    private void Start()
    {
        m_Speed = dane.spead;
        m_TurnSpeed = dane.r_spead;
        m_MovementInputValue = 0f;
        m_TurnInputValue = 0f;
        s = GameObject.Find("SpeadSlider").GetComponent<Slider>() as Slider;
        textmeshPro = GameObject.Find("Spead").GetComponent<TextMeshProUGUI>() as TextMeshProUGUI;
    }

    private void Update()
    {
        // Store the value of both input axes.
        m_MovementInputValue = Input.GetAxis("Vertical");
        m_TurnInputValue = Input.GetAxis("Horizontal");
        
        textmeshPro.text = spead.ToString();
        s.value = spead;

        EngineAudio();
    }


    private void EngineAudio()
    {
        // If there is no input (the tank is stationary)...
        if (Mathf.Abs(m_MovementInputValue) < 0.1f && Mathf.Abs(m_TurnInputValue) < 0.1f)
        {
           

            // ... and if the audio source is currently playing the driving clip...
            if (m_MovementAudio.clip == m_EngineDriving)
            {
                // ... change the clip to idling and play it.
                m_MovementAudio.clip = m_EngineIdling;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
        else
        {
         
           

            // Otherwise if the tank is moving and if the idling clip is currently playing...
            if (m_MovementAudio.clip == m_EngineIdling)
            {
                // ... change the clip to driving and play.
                m_MovementAudio.clip = m_EngineDriving;
                m_MovementAudio.pitch = Random.Range(m_OriginalPitch - m_PitchRange, m_OriginalPitch + m_PitchRange);
                m_MovementAudio.Play();
            }
        }
    }


    private void FixedUpdate()
    {
        // Adjust the rigidbodies position and orientation in FixedUpdate.
        if (kolizja)
        {
            Move();
            Turn();
            
            spead = Mathf.Round(speed());
        }
    }


    private void Move()
    {
        // Create a vector in the direction the tank is facing with a magnitude based on the input, speed and the time between frames.
        Vector3 movement = transform.forward * m_MovementInputValue * m_Speed * Time.deltaTime;

        // Apply this movement to the rigidbody's position.
        m_Rigidbody.MovePosition(m_Rigidbody.position + movement);
    }


    private void Turn()
    {
        // Determine the number of degrees to be turned based on the input, speed and time between frames.
        float turn = m_TurnInputValue * m_TurnSpeed * Time.deltaTime;

        // Make this into a rotation in the y axis.
        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        // Apply this rotation to the rigidbody's rotation.
        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);
    }


    private void OnCollisionStay(Collision collision)
    {
        kolizja = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        kolizja = false;
    }

    private float speed()
    {
        float S = (((transform.position - lastPosition).magnitude) / Time.deltaTime);
        lastPosition = transform.position;
        return S;
    }

}

   