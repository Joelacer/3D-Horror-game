using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCamera : MonoBehaviour
{
    public GameObject PlayerCamera;
    public Vector3 CameraPoint;


    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {


        if (other.tag == "Computer")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               StartCoroutine(onComputer(CameraPoint, 5));
            }
            
        }

        


    }

    public IEnumerator onComputer(Vector3 targetPosition, float duration)
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
    
        
    

}
