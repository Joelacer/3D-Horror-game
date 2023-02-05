using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cantopendoor : MonoBehaviour
{
    public GameObject player;
    public GameObject JanitorDoor;
    public GameObject BossDoor;

    bool fix = true;

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
       if(dooranimation.GetifDoor() == false && fix == true && Input.GetKey(KeyCode.E))
        {
            StartCoroutine(start());
           
        }
       else
        {
            StopAllCoroutines();
        }
    }

    

    IEnumerator start()
    {
        //yield return new WaitForSeconds(17f);
        fix = false;
        animator.SetBool("NewTask", true);
        yield return new WaitForSeconds(1.20f);
        animator.SetBool("NewTask", false);
        yield return new WaitForSeconds(2f);
        fix = true;
    }
}
