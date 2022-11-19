using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCamera : MonoBehaviour
{
    PlayerLook playerLook;
    PlayerMove playerMove;
    GameObject playerCamera;
    //ComputerScreen computerScreen;

    public bool onComputer;

    public Vector3 cameraPoint;
    public Vector3 targetRotation;
    public GameObject computerScreen;



    void Awake()
    {
        playerLook = GameObject.Find("Main Camera").GetComponent<PlayerLook>();
        playerCamera = GameObject.Find("Main Camera");
        playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
        //computerScreen = GameObject.Find("ComputerScreen").GetComponent<ComputerScreen>();
    }


    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Computer")
        {
            if (Input.GetKey(KeyCode.E))
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
        yield return new WaitForSeconds(1);
        computerScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.Confined;
    }

    
    
}

