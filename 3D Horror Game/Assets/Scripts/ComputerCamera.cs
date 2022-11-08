using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCamera : MonoBehaviour
{
    PlayerLook playerLook;
    //[SerializeField] GameObject playerCamera;

    public Vector3 cameraPoint;
    public Vector3 targetRotation;

    
    void Awake() // Finds the Camera and yoinks the PlayerLook script
    {
        playerLook = GameObject.Find("Main Camera").GetComponent<PlayerLook>();
    }


    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {


        if (other.tag == "Computer")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               playerLook.canLook = false;
               StartCoroutine(onComputer(cameraPoint, 2));
               StartCoroutine(LerpFunction(Quaternion.Euler(targetRotation), 2));
            }
            
        }

    }

    IEnumerator onComputer(Vector3 targetPosition, float duration)
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

        playerLook.canLook = true;
    }


    IEnumerator LerpFunction(Quaternion endValue, float duration)
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
}

