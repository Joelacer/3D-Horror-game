using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskScript : MonoBehaviour
{
    public GameObject TrashCan;

    Mopping mopping;
    TrashTask trashtask;

    public bool BroomTask = false;
    public bool TrashTask = false;
    public GameObject CheckBroom;
    public GameObject CheckTrash;

    // Start is called before the first frame update
    void Awake()
    {
        mopping = GameObject.Find("Player").GetComponent <Mopping>();
        trashtask = TrashCan.GetComponent<TrashTask>();
    }

     void Start()
    {
        CheckBroom.SetActive(false);
        CheckTrash.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(BroomTask == true)
        {
            CheckBroom.SetActive(true);
        }

        if (TrashTask == true)
        {
            CheckTrash.SetActive(true);
        }
        else
        {
            CheckTrash.SetActive(false);
        }


        if (mopping.GetCounter() == 3)
        {
            
            BroomTask = true;
        }

        if (trashtask.GetTCounter() == 4)
        {
            
            TrashTask = true;
        }
        else
        {
            TrashTask = false;
        }
    }


}
