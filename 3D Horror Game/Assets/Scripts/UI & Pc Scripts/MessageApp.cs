using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageApp : MonoBehaviour
{
    public GameObject TextJared;
    public GameObject TextMonster;
    public GameObject TextJaredCam;

    bool JaredTab = false;
    bool MonsterTab = false;

    public GameObject ShowTask;

    public GameObject NewMessageJared;
    public GameObject NewMessageMonster;

    bool LucasMSGReaction = false;

    Day2Task day2task;

    

    public bool GetMonsterTab()
    {
        return MonsterTab;
    }

    public bool GetJaredTab()
    {
        return JaredTab;
    }

    // Start is called before the first frame update
    void Awake()
    {
        TextJared.SetActive(false);
        TextMonster.SetActive(false);
        TextJaredCam.SetActive(false);

        day2task = ShowTask.GetComponent<Day2Task>();
    }

    // Update is called once per frame
    void Update()
    {
        //Day1

        if(JaredTab == true)
        {
            TextJared.SetActive(true);
        }
        else
        {
            TextJared.SetActive(false);
        }

        if (MonsterTab == true)
        {
            TextMonster.SetActive(true);
        }
        else
        {
            TextMonster.SetActive(false);
        }

        // Day2

        

        if (JaredTab == true && day2task.GetDay2() == true)
        {
            TextJaredCam.SetActive(true);
            TextJared.SetActive(false);
        }
        else
        {
            TextJaredCam.SetActive(false);
            TextJared.SetActive(false);
        }


    }

    // ON BUTTON PRESS

    public void Exit()
    {
        gameObject.SetActive(false);
    }

    public void jaredtab()
    {
        JaredTab = true;
        NewMessageJared.SetActive(false);

        MonsterTab = false;
    }

    public void monstertab()
    {
        MonsterTab = true;
        NewMessageMonster.SetActive(false);
        if (LucasMSGReaction == false)
        {
            Sound.PlaySound("Lucas_Msg_Reaction");
            Sound.PlaySound("SpookSound");
            LucasMSGReaction = true;
        }

        JaredTab = false;
    }

    
}
