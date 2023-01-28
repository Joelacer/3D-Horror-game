using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Emily : MonoBehaviour
{
    bool HaveTalked = false;
    public GameObject Player;


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            if (Input.GetKey(KeyCode.E) && HaveTalked == false)
            {
                StartCoroutine(TalkToEmily());
            }
        }
    }

    IEnumerator TalkToEmily()
    {
        HaveTalked = true;
      
        yield return new WaitForSeconds(2f);
        Sound.PlaySound("Lucas_Emily");
    }
}
