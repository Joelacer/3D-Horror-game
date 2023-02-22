using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Cam : MonoBehaviour
{
    bool HaveTalked = false;
    bool Look = false;
    public GameObject Player;
    

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
            if (Input.GetKey(KeyCode.E) && HaveTalked == false)
            {
                StartCoroutine(TalkToCam());
                
            }
        }
    }

    IEnumerator TalkToCam()
    {
        Look = true;
        HaveTalked = true;
        Sound.PlaySound("CamDay1Redo");
        yield return new WaitForSeconds(14f);
        Sound.PlaySound("Lucas_Cam");
        Look = false;
    }
}
