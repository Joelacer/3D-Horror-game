using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3Task : MonoBehaviour
{
    bool Day3;

    public GameObject DoneCheckMessage;
    public GameObject Paycheck;

    bool CanJumpscare = false;

    public bool GetDay3()
    {
        return Day3;
    }
    public bool GetJumpscare()
    {
        return CanJumpscare;
    }

    MessageApp messageapp;
    public GameObject messageAppOB;

    // Start is called before the first frame update
    void Start()
    {
        Day3 = true;
        Paycheck.SetActive(false);
        DoneCheckMessage.SetActive(false);

        messageapp = messageAppOB.GetComponent<MessageApp>();
    }

    // Update is called once per frame
    void Update()
    {
        if (messageapp.GetJaredTab() == true && Day3 == true)
        {
            DoneCheckMessage.SetActive(true);

            Paycheck.SetActive(true);
            CanJumpscare = true;
        }
    }
}
