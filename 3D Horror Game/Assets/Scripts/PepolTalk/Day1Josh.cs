using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Josh : MonoBehaviour
{
    bool HaveTalked = false;
    public GameObject Player;

    bool Look = false;
    

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
            if(Input.GetKey(KeyCode.E) && HaveTalked == false) 
            {
                StartCoroutine(TalkToJosh());
            }
        }
    }

    IEnumerator TalkToJosh()
    {
        Look = true;
        HaveTalked = true;
        Sound.PlaySound("JoshDay1");
        yield return new WaitForSeconds(8f);
        Sound.PlaySound("Lucas_Josh");
        Look = false;
        
        
        
    }
}
