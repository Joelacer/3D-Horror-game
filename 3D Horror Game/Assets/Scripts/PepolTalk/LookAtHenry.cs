using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtHenry : MonoBehaviour
{
    public Transform Target;



    Day1Cam day1cam;
    Day1Emily day1emily;
    Day1Henry day1henry;
    Day1Josh day1josh;
    // Start is called before the first frame update
    void Start()
    {
        //day1cam = GameObject.Find("Janitor_Cam").GetComponent<Day1Cam>();
        //day1emily = GameObject.Find("Coworker_Emily").GetComponent<Day1Emily>();
        day1henry = GameObject.Find("Coworker_Henry").GetComponent<Day1Henry>();
        //day1josh = GameObject.Find("Coworker_Josh").GetComponent<Day1Josh>();
    }

    // Update is called once per frame
    void Update()
    {
       // if (day1cam.GetLook() == true)
       // {
       //     transform.LookAt(Target);
       // }

        //if (day1emily.GetLook() == true)
        //{
        //    transform.LookAt(Target);
        //}

        if (day1henry.GetLook() == true)
        {

            transform.LookAt(Target);

        }

        // if (day1josh.GetLook() == true)
        // {
        //     transform.LookAt(Target);
        //}
    }
}
