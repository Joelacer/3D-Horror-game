using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoshJumpscare : MonoBehaviour
{
    Day2Task day2task;
    public GameObject Day2TaskOB;
    public GameObject Josh;
    public GameObject Camera;

    bool JoshvoicelinePlayed = false;
    bool SpookPlayed = false;

    bool Done = false;

    public bool GetDone()
    {
        return Done;
    }

    // Start is called before the first frame update
    void Start()
    {
        day2task = Day2TaskOB.GetComponent<Day2Task>();
    }

    // Update is called once per frame
    void Update()
    {
        if(day2task.GetJoshSpook() == true)
        {
            StartCoroutine(JoshTalk());
        }
    }

    IEnumerator JoshTalk()
    {
        Josh.SetActive(true);
        Camera.SetActive(true);

        if(SpookPlayed == false)
        {
            SpookPlayed = true;
            Sound.PlaySound("SpookSound");
        }

        yield return new WaitForSeconds(1f);

        if ( JoshvoicelinePlayed == false)
        {
            JoshvoicelinePlayed = true;
            Sound.PlaySound("JoshDay2");
        }

        yield return new WaitForSeconds(13f);
        Josh.SetActive(false);
        Camera.SetActive(false);
        Done = true;


    }
}
