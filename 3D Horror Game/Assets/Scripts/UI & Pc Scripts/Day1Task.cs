using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Task : MonoBehaviour
{
    public GameObject FixGameOB;
    public GameObject messageAppOB;

    public GameObject MonsterTab;

    public float toleave = 0f;
    public bool leave1 = false;
    public bool leave2 = false;
    public bool leave3 = false;
    public bool to1 = false;
    public bool to2 = false;
    public bool to3 = false;
    public GameObject LEAVE;

    public GameObject Player;

    public float GetToLeave()
    {
        return toleave;
    }

    ComputerCamera computercamera;
    FixGame fixgame;
    Day1Cam day1cam;
    Day1Emily day1emily;
    Day1Henry day1henry;
    Day1Josh day1josh;
    MessageApp messageapp;


    public GameObject DoneGoToYourPC;
    public GameObject DoneFixfiles;
    public GameObject Fixfiles;
    public GameObject DoneMeetYourCoworkers;
    public GameObject MeetYourCoworkers;
    public GameObject DoneInvestigatenoice;
    public GameObject Investigatenoice;

    bool doneGoToPC = false;
    bool doneFixFiles = false;
    bool doneMeet = false;

    bool msgsoundsplayed = false;

    public bool GetdoneFixFiles()
    {
        return doneFixFiles;
    }

    // Start is called before the first frame update
    void Start()
    {
        DoneGoToYourPC.SetActive(false);
        DoneFixfiles.SetActive(false);
        DoneMeetYourCoworkers.SetActive(false);
        Fixfiles.SetActive(false);
        MeetYourCoworkers.SetActive(false);
        DoneInvestigatenoice.SetActive(false);
        Investigatenoice.SetActive(false);
        LEAVE.SetActive(false);

        computercamera = Player.GetComponent<ComputerCamera>();
        fixgame = FixGameOB.GetComponent<FixGame>();
        day1cam = GameObject.Find("Janitor_Cam").GetComponent<Day1Cam>();
        day1emily = GameObject.Find("Coworker_Emily").GetComponent<Day1Emily>();
        day1henry = GameObject.Find("Coworker_Henry").GetComponent<Day1Henry>();
        day1josh = GameObject.Find("Coworker_Josh").GetComponent<Day1Josh>();
        messageapp = messageAppOB.GetComponent<MessageApp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (computercamera.GetonComputer() == true)
        {
            DoneGoToYourPC.SetActive(true);
            StartCoroutine(plustoleave());
            doneGoToPC = true;
            leave1 = true;
        }

        if (fixgame.GetTowin() == 4)
        {
            DoneFixfiles.SetActive(true);
            StartCoroutine(plustoleave());
            doneFixFiles = true;
            leave2 = true;
        }

        if(day1cam.GetHaveTalked() == true && day1emily.GetHaveTalked() == true && day1henry.GetHaveTalked() == true && day1josh.GetHaveTalked() == true)
        {
            DoneMeetYourCoworkers.SetActive(true);
            //StartCoroutine(plustoleave());
            //leave3 = true;
            doneMeet = true;
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

        if(doneMeet == true)
        {
            //Investigatenoice.SetActive(true);
            StartCoroutine(noicewait());
        }

        if(messageapp.GetMonsterTab() == true)
        {
            leave3 = true;
            DoneInvestigatenoice.SetActive(true);
            StartCoroutine(plustoleave());
        }



       
    }

    IEnumerator plustoleave()
    {
        if (leave1 == true && to1 == false)
        {
            yield return new WaitForSeconds(1);
            toleave =+ 1;
            to1 = true;
        }
        if (leave2 == true && to2 == false)
        {
            yield return new WaitForSeconds(1);
            toleave =+ 2;
            to2 = true;
        }
        if (leave3 == true && to3 == false)
        {
            yield return new WaitForSeconds(1);
            toleave =+ 3;
            to3 = true;
        }
    }

    IEnumerator noicewait()
    {
        yield return new WaitForSeconds(20f);
        if (msgsoundsplayed == false)
        {
            msgsoundsplayed = true;
            Sound.PlaySound("MSG_Sound");
            yield return new WaitForSeconds(1f);
            Sound.PlaySound("Lucas_Msg");
        }

        Investigatenoice.SetActive(true);
        MonsterTab.SetActive(true);
        
    }




}
