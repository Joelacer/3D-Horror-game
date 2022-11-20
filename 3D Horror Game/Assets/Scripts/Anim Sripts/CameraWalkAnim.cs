using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWalkAnim : MonoBehaviour
{
    Animator animator;
    PlayerMove playerMove;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMove.GetWalk() == true)
        {
            animator.SetBool("IsWalking", true);
        }
        if (playerMove.GetWalk() == false)
        {
            animator.SetBool("IsWalking", false);
        }

        if (playerMove.GetRun() == true)
        {
            animator.SetBool("IsRuning", true);
        }
        if (playerMove.GetRun() == false)
        {
            animator.SetBool("IsRuning", false);
        }
    }
}
