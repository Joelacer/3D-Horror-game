using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tsystem : MonoBehaviour
{
    public GameObject DotsOB;
    bool PressedT = false;
    bool SpamFix = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            PressedT = true;
            gameObject.SetActive(false);
        }

        if(PressedT == false && SpamFix == false)
        {
            StartCoroutine(Dots());
        }
        else if (PressedT == true)
        {
            StopCoroutine(Dots());
        }
    }

    IEnumerator Dots()
    {
        SpamFix = true;
        //yield return new WaitForSeconds(1f);
        DotsOB.SetActive(true);
        yield return new WaitForSeconds(1f);
        DotsOB.SetActive(false);
        yield return new WaitForSeconds(1f);
        SpamFix = false;

    }
}
