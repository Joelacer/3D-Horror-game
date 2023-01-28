using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Cam : MonoBehaviour
{
    bool HaveTalked = false;
    public GameObject Player;


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player)
        {
            if (Input.GetKey(KeyCode.E) && HaveTalked == false)
            {
                StartCoroutine(TalkToCam());
            }
        }
    }

    IEnumerator TalkToCam()
    {
        HaveTalked = true;
        Sound.PlaySound("CamDay1Redo");
        yield return new WaitForSeconds(14f);
        Sound.PlaySound("Lucas_Cam");
    }
}
