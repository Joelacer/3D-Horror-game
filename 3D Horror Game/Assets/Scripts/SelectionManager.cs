using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public GameObject EShow;

    PhysicsPickUp pickUp;


    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Trash" )
        {
            if(pickUp.GetPickup() == false)
            {
                EShow.SetActive(true);
            }
            else if(pickUp.GetPickup() == true)
            {
                EShow.SetActive(false);
            }
            
               
           
        }
        else
        {
            EShow.SetActive(false);
        }

    }

     void Awake()
    {
        pickUp = GameObject.Find("Player").GetComponent<PhysicsPickUp>();
    }

    // Start is called before the first frame update
    void Start()
    {
        EShow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
