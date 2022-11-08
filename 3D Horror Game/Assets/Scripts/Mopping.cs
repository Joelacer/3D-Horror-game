using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mopping : MonoBehaviour
{
    public GameObject Broom;
    public bool isMopping = false;
    public bool MopisOn;
    
    public float MopCounter = 0;
    public int CleanCounter = 0;
    public int SoundCooldown = 1;

    bool soundplayed = false;

    // Start is called before the first frame update
    void Start()
    {
        Broom.SetActive(false);
        MopisOn = false;
    }
    public int GetCounter()
    {
        return CleanCounter;
    }

    public bool GetMop()
    {
        return MopisOn;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            isMopping = true;
            
        }
        else
        {
            isMopping = false;
            MopCounter = 0;
          
        }

        if(isMopping == true && MopisOn == true && soundplayed == false)
        {
            StartCoroutine(sound());
        }
        


    }

     void OnTriggerStay(Collider target)
    {
        
        if (target.tag == "CanMop")
        {
            if(isMopping == true && MopisOn == true)
            {
                MopCounter += 1;
                
            }

            if (MopCounter > 150)
            {
                Destroy(target.gameObject);
                MopCounter = 0;
                CleanCounter += 1;
            }
        }

        if (target.tag == "BroomGet" && Input.GetKey(KeyCode.E) && MopisOn == false)
        {
            Broom.SetActive(true);
            MopisOn = true;
        }

        if (target.tag == "BroomGet" && Input.GetKey(KeyCode.Q) && MopisOn == true)
        {
            Broom.SetActive(false);
            MopisOn = false;
        }


    }

    IEnumerator sound()
    {

        Sound.PlaySound("Broom");
        soundplayed = true;
        yield return new WaitForSeconds(SoundCooldown);
        soundplayed = false;

    }
    
    
}
