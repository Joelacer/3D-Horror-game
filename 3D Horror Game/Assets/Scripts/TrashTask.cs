using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashTask : MonoBehaviour
{
    public float TrashCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Trash")
        {
            TrashCounter += 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Trash")
        {
            TrashCounter -= 1;
        }
    }
}
