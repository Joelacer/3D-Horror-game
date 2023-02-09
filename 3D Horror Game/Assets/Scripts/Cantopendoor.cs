using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cantopendoor : MonoBehaviour
{
    public GameObject player;
    public GameObject JanitorDoor;
    public GameObject BossDoor;

    bool fix = true;

    public bool Getfix()
    {
        return fix;
    }

    Animator animator;
    DoorAnimation dooranimation;

    // Start is called before the first frame update
    void Start()

    {
        animator = GetComponent<Animator>();
        dooranimation = BossDoor.GetComponent<DoorAnimation>();
        dooranimation = JanitorDoor.GetComponent<DoorAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
       if(dooranimation.GetifDoor() == false && fix == true)
        {
            StartCoroutine(start());
           
        }
       
    }

    

    IEnumerator start()
    {
        //yield return new WaitForSeconds(0.5f);
        //fix = false;
        animator.SetBool("NewTask", true);
        yield return new WaitForSeconds(1.20f);
        animator.SetBool("NewTask", false);
        //yield return new WaitForSeconds(2f);
        //fix = true;
    }
}
