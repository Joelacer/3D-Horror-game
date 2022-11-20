using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 25.0F;
    
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;

    public bool isSprinting = false;
    public float sprintingMultiplier;
    public GameObject playerAsset;
    public bool canMove = true;
    
    

    // Use this for initialization
    void Start()
    {
        playerAsset.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove == true)
        {
            CharacterController controller = GetComponent<CharacterController>();
            // is the controller on the ground?
            if (controller.isGrounded)
            {
                //Feed moveDirection with input.
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                //Multiply it by speed.
                moveDirection *= speed;
                //Jumping


                if (Input.GetKey(KeyCode.LeftShift))
                {
                    isSprinting = true;
                }
                else
                {
                    isSprinting = false;
                }

                if (isSprinting == true)
                {
                    moveDirection *= sprintingMultiplier;
                }
            }


            //Applying gravity to the controller
            moveDirection.y -= gravity * Time.deltaTime;
            //Making the character move
            controller.Move(moveDirection * Time.deltaTime);
        }

        
    }
}