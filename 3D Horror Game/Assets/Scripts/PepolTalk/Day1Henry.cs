using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Henry : MonoBehaviour
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
                StartCoroutine(TalkToHenry());
            }
        }
    }

    IEnumerator TalkToHenry()
    {
        transform.rotation = Quaternion.Euler(0, 100, 0);
        Look = true;
        HaveTalked = true;
        Sound.PlaySound("Henry_Lucas");
        yield return new WaitForSeconds(11f);
        Sound.PlaySound("Lucas_Henry");
        Look = false;
        transform.rotation = Quaternion.Euler(0, 1345, 0);
    }
}
