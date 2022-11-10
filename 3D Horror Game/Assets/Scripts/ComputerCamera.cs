using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCamera : MonoBehaviour
{
    PlayerLook playerLook;
    PlayerMove playerMove;
    GameObject playerCamera;

    bool onComputer;

    public Vector3 cameraPoint;
    public Vector3 targetRotation;



    void Awake()
    {
        playerLook = GameObject.Find("Main Camera").GetComponent<PlayerLook>();
        playerCamera = GameObject.Find("Main Camera");
        playerMove = GameObject.Find("Player 1").GetComponent<PlayerMove>();
    }


    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Computer")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {

                playerLook.canLook = false;
                playerMove.canMove = false;
                onComputer = true;
                StartCoroutine(toComputer(cameraPoint, 1));
                StartCoroutine(LerpFunction(Quaternion.Euler(targetRotation), 1));
                //I was very upset while doing this one so ignore the name
                StartCoroutine(rotateShit());

            }
            
        }

    }


    IEnumerator toComputer(Vector3 targetPosition, float duration) //Movement
    {
        float time = 0;
        Vector3 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;

    }


    IEnumerator LerpFunction(Quaternion endValue, float duration) //Rotation
    {
        float time = 0;
        Quaternion startValue = transform.rotation;
        while (time < duration)
    {
        transform.rotation = Quaternion.Lerp(startValue, endValue, time / duration);
        time += Time.deltaTime;
        yield return null;
    }
        transform.rotation = endValue;

    }


    IEnumerator rotateShit()
    {
        playerCamera.transform.localRotation = Quaternion.Euler(10f, 0f, 0f);
        yield return new WaitForSeconds(0);
    }

    private void Update()
    {
        if (onComputer == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                playerLook.canLook = true;
                playerMove.canMove = true;
                onComputer = false;
            }
        }
    }
}

