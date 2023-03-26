using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageApp : MonoBehaviour
{
    public GameObject TextJared;
    public GameObject TextMonster;
    public GameObject TextJaredCam;
    public GameObject TextJosh;
    public GameObject TextJaredMonster;

    bool JaredTab = false;
    bool MonsterTab = false;
    //bool JaredCamTab = false;
    bool JoshTab = false;

    public GameObject ShowTask;
    public GameObject JoshjumpscareOB;

    public GameObject NewMessageJared;
    public GameObject NewMessageMonster;
    public GameObject NewMessageJosh;
    public GameObject NewMessageJaredMonster;

    public GameObject JoshMessage;

    bool LucasMSGReaction = false;

    Day2Task day2task;
    JoshJumpscare joshjumpscare;
    Day3Task day3task;

    bool SoundPlayedLastWords = false;



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
        //TextJaredCam.SetActive(false);
        TextJosh.SetActive(false);
        JoshMessage.SetActive(false);

        day2task = ShowTask.GetComponent<Day2Task>();
        joshjumpscare = JoshjumpscareOB.GetComponent<JoshJumpscare>();
        day3task = ShowTask.GetComponent<Day3Task>();
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

        if (JoshTab == true && day2task.GetDay2() == true)
        {
            TextJosh.SetActive(true);
            
        }
        else
        {
            TextJosh.SetActive(false);
            
        }

        if (joshjumpscare.GetDone() == true)
        {
            JoshMessage.SetActive(true);
        }

        // Day3

        if (JaredTab == true && day3task.GetDay3() == true)
        {
            TextJaredMonster.SetActive(true);
            if (SoundPlayedLastWords == false)
            {
                Sound.PlaySound("Lucas_LastWords");
                SoundPlayedLastWords = true;
            }
        }
        else
        {
            TextJaredMonster.SetActive(false);
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
        JoshTab = false;
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

    public void joshtab()
    {
        JoshTab = true;
        NewMessageJosh.SetActive(false);

        JaredTab = false;
    }

    
}
