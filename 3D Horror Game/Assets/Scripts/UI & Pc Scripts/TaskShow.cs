using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskShow : MonoBehaviour
{
    Animator animator;

    bool IN = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T) && IN == true)
        {
            
            StartCoroutine(ShowTask());
        }

        if (Input.GetKey(KeyCode.T) && IN == false)
        {
           
            StartCoroutine(ShowTaskOUT());
        }
    }

    IEnumerator ShowTask()
    {
        animator.SetBool("ShowTask", true);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("ShowTask2", true);
        IN = false;

    }

    IEnumerator ShowTaskOUT()
    {
        animator.SetBool("ShowTask", false);
        yield return new WaitForSeconds(0.5f);
        animator.SetBool("ShowTask2", false);
        IN = true;
    }
}
