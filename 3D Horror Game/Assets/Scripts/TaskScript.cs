using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript : MonoBehaviour
{
   private Mopping MopCounter;

    // Start is called before the first frame update
    void Start()
    {
        MopCounter = GetComponent<Mopping>();
    }

    // Update is called once per frame
    void Update()
    {
        //if(MopCounter == 2)
        //{

        //}
    }
}
