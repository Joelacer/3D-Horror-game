using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Task : MonoBehaviour
{
    public GameObject FixGameOB;

    float toleave = 0f;
    public GameObject LEAVE;

    public GameObject Player;

    ComputerCamera computercamera;
    FixGame fixgame;
    Day1Cam day1cam;
    Day1Emily day1emily;
    Day1Henry day1henry;
    Day1Josh day1josh;


    public GameObject DoneGoToYourPC;
    public GameObject DoneFixfiles;
    public GameObject Fixfiles;
    public GameObject DoneMeetYourCoworkers;
    public GameObject MeetYourCoworkers;

    bool doneGoToPC = false;
    bool doneFixFiles = false;

    // Start is called before the first frame update
    void Start()
    {
        DoneGoToYourPC.SetActive(false);
        DoneFixfiles.SetActive(false);
        DoneMeetYourCoworkers.SetActive(false);
        Fixfiles.SetActive(false);
        MeetYourCoworkers.SetActive(false);
        LEAVE.SetActive(false);

        computercamera = Player.GetComponent<ComputerCamera>();
        fixgame = FixGameOB.GetComponent<FixGame>();
        day1cam = GameObject.Find("Janitor_Cam").GetComponent<Day1Cam>();
        day1emily = GameObject.Find("Coworker_Emily").GetComponent<Day1Emily>();
        day1henry = GameObject.Find("Coworker_Henry").GetComponent<Day1Henry>();
        day1josh = GameObject.Find("Coworker_Josh").GetComponent<Day1Josh>();
    }

    // Update is called once per frame
    void Update()
    {
        if (computercamera.GetonComputer() == true)
        {
            DoneGoToYourPC.SetActive(true);
            toleave = +1;
            doneGoToPC = true;
        }

        if (fixgame.GetTowin() == 4)
        {
            DoneFixfiles.SetActive(true);
            toleave = +1;
            doneFixFiles = true;
        }

        if(day1cam.GetHaveTalked() == true && day1emily.GetHaveTalked() == true && day1henry.GetHaveTalked() == true && day1josh.GetHaveTalked() == true)
        {
            DoneMeetYourCoworkers.SetActive(true);
            toleave = +1;
        }

        if (toleave == 3)
        {
            LEAVE.SetActive(true);
        }

        if (doneGoToPC == true)
        {
            Fixfiles.SetActive(true);
        }

        if (doneFixFiles == true)
        {
            MeetYourCoworkers.SetActive(true);
        }

       
    }


   
}
