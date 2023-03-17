using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task : MonoBehaviour
{
    bool Day2 = false;

    bool Task6 = false;
    bool JoshSpook = false;
    public GameObject JoshScare;

    bool Day2DoneDone = false;

    public bool GetJoshSpook()
    {
        return JoshSpook;
    }

    public bool GetDay2Done()
    {
        return Day2DoneDone;
    }

    bool JanitorDoor = false;
    public bool GetjanitorDoor()
    {
        return JanitorDoor;
    }

    MessageApp messageapp;
    public GameObject messageAppOB;
    TrashTask trashtask;
    public GameObject trashTaskOB;
    DoorAnimJanitor dooranimjanitor;
    public GameObject JanitorDoorOB;
    CleanText cleantext;
    public GameObject TextOB;
    Mopping mopping;
    public GameObject BroomOB;
    ComputerCamera computercamera;
    JoshJumpscare joshjumpscare;
    public GameObject JoshscareOB;
    ColorGame colorgame;
    public GameObject ComputerScreenOB;

    public GameObject CheckMessages;
    public GameObject DoneCheckMessages;
    public GameObject CleanTrash;
    public GameObject DoneCleanTrash;
    public GameObject GoGetBroom;
    public GameObject DoneGoGetBroom;
    public GameObject CleanWriting;
    public GameObject DoneCleamWriting;
    public GameObject Broom;
    public GameObject DoneBroom;
    public GameObject GoToPC;
    public GameObject DoneGotoPC;
    public GameObject Firewall;
    public GameObject DoneFirewall;
    public GameObject Leave;

    public GameObject OneTwoTasks;

    public bool GetDay2()
    {
        return Day2;
    }

    // Start is called before the first frame update
    void Start()
    {
        Day2 = true;
        JoshScare.SetActive(false);

        messageapp = messageAppOB.GetComponent<MessageApp>();
        trashtask = trashTaskOB.GetComponent<TrashTask>();
        dooranimjanitor = JanitorDoorOB.GetComponent<DoorAnimJanitor>();
        cleantext = TextOB.GetComponent<CleanText>();
        mopping = BroomOB.GetComponent<Mopping>();
        computercamera = BroomOB.GetComponent<ComputerCamera>();
        joshjumpscare = JoshscareOB.GetComponent<JoshJumpscare>();
        colorgame = ComputerScreenOB.GetComponent<ColorGame>();


        DoneCheckMessages.SetActive(false);
        CleanTrash.SetActive(false);
        DoneCleanTrash.SetActive(false);
        GoGetBroom.SetActive(false);
        DoneGoGetBroom.SetActive(false);
        CleanWriting.SetActive(false);
        DoneCleamWriting.SetActive(false);
        Broom.SetActive(false);
        DoneBroom.SetActive(false);
        GoToPC.SetActive(false);
        DoneGotoPC.SetActive(false);
        Firewall.SetActive(false);
        DoneFirewall.SetActive(false);
        Leave.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // check messages TASK1

        if(messageapp.GetJaredTab() == true && Day2 == true)
        {
            DoneCheckMessages.SetActive(true);
            CleanTrash.SetActive(true);
        }

        //Clean Trash TASK2

        if (trashtask.GetTCounter() == 6 && Day2 == true)
        {
            DoneCleanTrash.SetActive(true);
            JanitorDoor = true;
            GoGetBroom.SetActive(true);
        }

        //Get Broom TASK3
        
        if (dooranimjanitor.Getday2task() == true)
        {
            DoneGoGetBroom.SetActive(true);

            DoneCheckMessages.SetActive(false);
            CleanTrash.SetActive(false);
            DoneCleanTrash.SetActive(false);
            GoGetBroom.SetActive(false);
            DoneGoGetBroom.SetActive(false);
            CheckMessages.SetActive(false);

            CleanWriting.SetActive(true);
        }

        //Clean Writing TASK4

        if(cleantext.GetCleaned() == true)
        {
            DoneCleamWriting.SetActive(true);

            Broom.SetActive(true);
        }

        //Broom TASK5

        if(mopping.GetCounter() == 4)
        {
            DoneBroom.SetActive(true);

            GoToPC.SetActive(true);
            Task6 = true;
        }

        //Go To PC TASK6

        if(computercamera.GetonComputer() == true && Day2 == true && Task6 == true)
        {
            //JoshScare.SetActive(true);
            JoshSpook = true;
            DoneGotoPC.SetActive(true);

            CheckMessages.SetActive(false);
            DoneCheckMessages.SetActive(false);
            CleanTrash.SetActive(false);
            DoneCleanTrash.SetActive(false);
            GoGetBroom.SetActive(false);
            DoneGoGetBroom.SetActive(false);
            CleanWriting.SetActive(false);
            DoneCleamWriting.SetActive(false);
            Broom.SetActive(false);
            DoneBroom.SetActive(false);
            GoToPC.SetActive(false);
            DoneGotoPC.SetActive(false);
            OneTwoTasks.SetActive(false);

            Firewall.SetActive(true);
        }

        if (joshjumpscare.GetDone() == true)
        {
            JoshSpook = false;
            Task6 = false;
        }

        //Help with firewall TASK7

        if(colorgame.GetDone() == true)
        {
            DoneFirewall.SetActive(true);

            Leave.SetActive(true);
            Day2DoneDone = true;
        }

        


    }
}
