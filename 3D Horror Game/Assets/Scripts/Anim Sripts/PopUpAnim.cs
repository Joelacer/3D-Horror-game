using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpAnim : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(start());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator start()
    {
        yield return new WaitForSeconds(17f);
        animator.SetBool("NewTask", true);
        yield return new WaitForSeconds(1.20f);
        animator.SetBool("NewTask", false);
    }
}
