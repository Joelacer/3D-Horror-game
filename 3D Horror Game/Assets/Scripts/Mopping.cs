using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mopping : MonoBehaviour
{
    public GameObject Mop;
    public bool isMopping = false;
    public float MopCooldown = 5;
    public float MopCounter = 0;
    public float CleanCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isMopping = true;
        }
        else
        {
            isMopping = false;
          
        }

        
    }

     void OnTriggerStay(Collider target)
    {
        //Debug.Log("Diet");
        if (target.tag == "CanMop")
        {
            if(isMopping == true)
            {
                MopCounter += 1;
                
            }

            //Debug.Log("Diet");
            //Destroy(target.gameObject);

            if (MopCounter > 150)
            {
                Destroy(target.gameObject);
                MopCounter = 0;
                CleanCounter += 1;
            }
        }

         
    }

    
    
    
}
