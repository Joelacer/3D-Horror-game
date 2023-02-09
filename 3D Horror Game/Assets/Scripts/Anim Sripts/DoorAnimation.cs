using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    Animator animator;

    Cantopendoor cantopendoor;

    bool SoundPlayed = false;
    bool ClosePlayed = false;
    bool allsoundPlayed = true;
    float bugwait = 0.3f;

    public bool GetifDoor()
    {
        return allsoundPlayed;
    }
    public GameObject cantopendoorOB;
        

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       
        cantopendoor = cantopendoorOB.GetComponent<Cantopendoor>();
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
        if(cantopendoor.Getfix() == false)
        {
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
        else if (cantopendoor.Getfix() == true)
        {
            allsoundPlayed = false;
            yield return new WaitForSeconds(1.2f);
            allsoundPlayed = true;

        }
    }
    
}
