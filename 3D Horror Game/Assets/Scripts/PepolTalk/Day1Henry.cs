using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Henry : MonoBehaviour
{
    bool HaveTalked = false;
    public GameObject Player;


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            if (Input.GetKey(KeyCode.E) && HaveTalked == false)
            {
                StartCoroutine(TalkToHenry());
            }
        }
    }

    IEnumerator TalkToHenry()
    {
        HaveTalked = true;
        Sound.PlaySound("Henry_Lucas");
        yield return new WaitForSeconds(11f);
        Sound.PlaySound("Lucas_Henry");
    }
}
