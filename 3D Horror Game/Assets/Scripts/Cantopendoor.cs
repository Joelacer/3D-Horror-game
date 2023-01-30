using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cantopendoor : MonoBehaviour
{
    public GameObject player;
    public GameObject JanitorDoor;

    Animator animator;
    DoorAnimation dooranimation;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        dooranimation = GameObject.Find("door").GetComponent<DoorAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
       if(dooranimation.GetifDoor() == false)
        {
            StartCoroutine(start());
        }
    }

    

    IEnumerator start()
    {
        //yield return new WaitForSeconds(17f);
        animator.SetBool("NewTask", true);
        yield return new WaitForSeconds(1.20f);
        animator.SetBool("NewTask", false);
    }
}
