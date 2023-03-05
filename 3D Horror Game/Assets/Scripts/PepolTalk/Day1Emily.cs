using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Emily : MonoBehaviour
{
    bool HaveTalked = false;
    public GameObject Player;
    bool Look = false;

    Day1Task day1task;
    public GameObject ShowTask;

    void Start()
    {
        day1task = ShowTask.GetComponent<Day1Task>();
    }

    public bool GetHaveTalked()
    {
        return HaveTalked;
    }

    public bool GetLook()
    {
        return Look;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            if (Input.GetKey(KeyCode.E) && HaveTalked == false && day1task.GetdoneFixFiles() == true)
            {
                StartCoroutine(TalkToEmily());
            }
        }
    }

    IEnumerator TalkToEmily()
    {
        transform.rotation = Quaternion.Euler(0, 230, 0);
        Look = true;
        HaveTalked = true;
      
        yield return new WaitForSeconds(2f);
        Sound.PlaySound("Lucas_Emily");
        Look = false;
        transform.rotation = Quaternion.Euler(0, 65, 0);
    }
}
