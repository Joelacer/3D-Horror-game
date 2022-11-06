using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    public GameObject EShow;
    public GameObject QShow;

    PhysicsPickUp pickUp;
    Mopping mopping;

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

        

        if (other.tag == "Door")
        {
            EShow.SetActive(true);
        }

        if (other.tag == "BroomGet" && mopping.GetMop() == false)
        {
            EShow.SetActive(true);
        }
        else if (other.tag == "BroomGet" && mopping.GetMop() == true)
        {
            EShow.SetActive(false);
        }

            if (other.tag == "BroomGet" && mopping.GetMop() == true)
        {
            QShow.SetActive(true);
        }
        else if (other.tag == "BroomGet" && mopping.GetMop() == false)
        {
            QShow.SetActive(false);
        }


    }
     void OnTriggerExit(Collider other)
    {
        if (other.tag == "Trash")
        {
            EShow.SetActive(false);
        }

        if (other.tag == "Door")
        {
            EShow.SetActive(false);
        }

        if (other.tag == "BroomGet" && mopping.GetMop() == false)
        {
            EShow.SetActive(false);
        }
        if (other.tag == "BroomGet" && mopping.GetMop() == true)
        {
            QShow.SetActive(false);
        }
    }


    void Awake()
    {
        pickUp = GameObject.Find("Player").GetComponent<PhysicsPickUp>();
        mopping = GameObject.Find("Player").GetComponent<Mopping>();
    }

    // Start is called before the first frame update
    void Start()
    {
        EShow.SetActive(false);
        QShow.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
