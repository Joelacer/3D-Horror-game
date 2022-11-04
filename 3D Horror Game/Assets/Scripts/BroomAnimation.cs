using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroomAnimation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            animator.SetBool("isSweeping", true);
        }

        if (!Input.GetMouseButton(0))
        {
            animator.SetBool("isSweeping", false);
        }
    }
}
