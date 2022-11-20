using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip Broom, DoorOpen, DoorClose, Button, ButtonWrong, Step;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {


        Broom = Resources.Load<AudioClip>("Broom");
        DoorOpen = Resources.Load<AudioClip>("DoorOpen");
        DoorClose = Resources.Load<AudioClip>("DoorClose");
        Button = Resources.Load<AudioClip>("Button");
        ButtonWrong = Resources.Load<AudioClip>("ButtonWrong");
        Step = Resources.Load<AudioClip>("Step");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {


            case "Broom":
                audioSrc.PlayOneShot(Broom);
                break;

            case "DoorOpen":
                audioSrc.PlayOneShot(DoorOpen);
                break;

            case "DoorClose":
                audioSrc.PlayOneShot(DoorClose);
                break;

            case "Button":
                audioSrc.PlayOneShot(Button);
                break;

            case "ButtonWrong":
                audioSrc.PlayOneShot(ButtonWrong);
                break;

            case "Step":
                audioSrc.Play();
                audioSrc.PlayOneShot(Step);
                break;

            case "StepStop":
                audioSrc.Stop();
                break;

            case "StepPlay":
                audioSrc.Play();
                break;


        }
    }



}
