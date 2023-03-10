using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Task : MonoBehaviour
{
    bool Day2 = false;

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

    public GameObject CheckMessages;
    public GameObject DoneCheckMessages;
    public GameObject CleanTrash;
    public GameObject DoneCleanTrash;
    public GameObject GoGetBroom;
    public GameObject DoneGoGetBroom;

    public bool GetDay2()
    {
        return Day2;
    }

    // Start is called before the first frame update
    void Start()
    {
        Day2 = true;

        messageapp = messageAppOB.GetComponent<MessageApp>();
        trashtask = trashTaskOB.GetComponent<TrashTask>();
        dooranimjanitor = JanitorDoorOB.GetComponent<DoorAnimJanitor>();

        DoneCheckMessages.SetActive(false);
        CleanTrash.SetActive(false);
        DoneCleanTrash.SetActive(false);
        GoGetBroom.SetActive(false);
        DoneGoGetBroom.SetActive(false);
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
        }


    }
}
