using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessageApp : MonoBehaviour
{
    public GameObject TextJared;
    public GameObject TextMonster;

    bool JaredTab = false;
    bool MonsterTab = false;

    public GameObject NewMessageJared;
    public GameObject NewMessageMonster;

    bool LucasMSGReaction = false;

    

    public bool GetMonsterTab()
    {
        return MonsterTab;
    }

    // Start is called before the first frame update
    void Start()
    {
        TextJared.SetActive(false);
        TextMonster.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
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
