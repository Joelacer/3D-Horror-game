using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip Broom, DoorOpen, DoorClose, Button, ButtonWrong, Step, CanIHelpU, bossStart, CamDay1Redo, JoshDay1, Lucas_Emily, Lucas_FixGame_2, Lucas_FixGame_3, Lucas_FixGame_Done, Lucas_FixGame_Start, Lucas_Henry, Lucas_Josh, Lucas_Cam;
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

        bossStart = Resources.Load<AudioClip>("bossStart");

        CanIHelpU = Resources.Load<AudioClip>("CanIHelpU");

        CamDay1Redo = Resources.Load<AudioClip>("CamDay1Redo");
        JoshDay1 = Resources.Load<AudioClip>("JoshDay1");
        Lucas_Emily = Resources.Load<AudioClip>("Lucas_Emily");
        Lucas_FixGame_2 = Resources.Load<AudioClip>("Lucas_FixGame_2");
        Lucas_FixGame_3 = Resources.Load<AudioClip>("Lucas_FixGame_3");
        Lucas_FixGame_Done = Resources.Load<AudioClip>("Lucas_FixGame_Done");
        Lucas_FixGame_Start = Resources.Load<AudioClip>("Lucas_FixGame_Start");
        Lucas_Henry = Resources.Load<AudioClip>("Lucas_Henry");
        Lucas_Josh = Resources.Load<AudioClip>("Lucas_Josh");
        Lucas_Cam = Resources.Load<AudioClip>("Lucas_Cam");

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
                
                audioSrc.PlayOneShot(Step);
                break;

           




            case "CanIHelpU":
                audioSrc.PlayOneShot(CanIHelpU);
                break;

            case "bossStart":
                audioSrc.PlayOneShot(bossStart);
                break;



            case "CamDay1Redo":
                audioSrc.PlayOneShot(CamDay1Redo);
                break;

            case "JoshDay1":
                audioSrc.PlayOneShot(JoshDay1);
                break;

            case "Lucas_Emily":
                audioSrc.PlayOneShot(Lucas_Emily);
                break;

            case "Lucas_FixGame_2":
                audioSrc.PlayOneShot(Lucas_FixGame_2);
                break;

            case "Lucas_FixGame_3":
                audioSrc.PlayOneShot(Lucas_FixGame_3 );
                break;

            case "Lucas_FixGame_Done":
                audioSrc.PlayOneShot(Lucas_FixGame_Done );
                break;

            case "Lucas_FixGame_Start":
                audioSrc.PlayOneShot(Lucas_FixGame_Start);
                break;

            case "Lucas_Henry":
                audioSrc.PlayOneShot(Lucas_Henry);
                break;

            case "Lucas_Josh":
                audioSrc.PlayOneShot(Lucas_Josh);
                break;

            case "Lucas_Cam":
                audioSrc.PlayOneShot(Lucas_Cam);
                break;

        }
    }



}
