using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimJanitor : MonoBehaviour
{
    Animator animator;

    bool Day2Task = false;
    public bool Getday2task()
    {
        return Day2Task;
    }

    Day2Task day2task;
    public GameObject ShowTask;

    bool SoundPlayed = false;
    bool ClosePlayed = false;
    bool allsoundPlayed = true;
    float bugwait = 0.3f;
    bool cantdoor = true;

    public bool GetifDoor()
    {
        return cantdoor;
    }
    public GameObject cantopendoorOB;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        
        day2task = ShowTask.GetComponent<Day2Task>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(StartCooldown());
            }

            if (allsoundPlayed == true)
            {
                SoundPlayed = false;
                ClosePlayed = false;
            }
        }
    }

    public IEnumerator StartCooldown()
    {
        if (day2task.GetjanitorDoor() == true)
        {
            Day2Task = true;
            allsoundPlayed = false;
            animator.SetBool("isOpening", true);

            if (SoundPlayed == false)
            {
                Sound.PlaySound("DoorOpen");
                SoundPlayed = true;
            }

            yield return new WaitForSeconds(5);
            animator.SetBool("isOpening", false);

            if (ClosePlayed == false)
            {
                ClosePlayed = true;
                Sound.PlaySound("DoorClose");

            }
            yield return new WaitForSeconds(bugwait);
            allsoundPlayed = true;
        }

        else if (day2task.GetjanitorDoor() == false)
        {
            cantdoor = false;
            yield return new WaitForSeconds(1.2f);
            cantdoor = true;

        }





    }

}
