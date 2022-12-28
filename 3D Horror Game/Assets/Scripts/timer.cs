using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Image timerbar;
    public float maxTime = 10f;
    float timeleft;
    public GameObject UI;

    bool regengame1USED = false;
    bool regengame2USED = false;
    bool regengame3USED = false;

    bool REopengame = false;

    public bool GetREopengame()
    {
        return REopengame;
    }

    ColorGame colorgameSC;
    

    // Start is called before the first frame update
    void Start()
    {
        colorgameSC = GameObject.Find("ColorGame").GetComponent<ColorGame>();

        timerbar = GetComponent<Image>();
        timeleft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeleft > 0)
        {
            timeleft -= Time.deltaTime;
            timerbar.fillAmount = timeleft / maxTime;

            if (colorgameSC.GetGame1() == true && regengame1USED == false)
            {
                timeleft = maxTime;
                regengame1USED = true;
                REopengame = false;
            }
            if (colorgameSC.GetGame2() == true && regengame2USED == false)
            {
                timeleft = maxTime;
                regengame2USED = true;
                
            }
            if (colorgameSC.GetGame3() == true && regengame3USED == false)
            {
                timeleft = maxTime;
                regengame3USED = true;
                
            }

        }
        else
        {
            //Time.timeScale = 0;
            UI.SetActive(false);
            regengame2USED = false;
            regengame3USED = false;
            regengame1USED = false;
            timeleft = maxTime;
            
            if (colorgameSC.GetGame2() == true || colorgameSC.GetGame3() == true)
            {
                REopengame = true;
            }
            else if (colorgameSC.GetGame1() == true)
            {
                REopengame = false;
            }

        }

        
        
    }
}
