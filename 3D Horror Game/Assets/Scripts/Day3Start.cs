using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3Start : MonoBehaviour
{
    public GameObject black;
    public GameObject fadein;
    public GameObject fadeout;
    bool SoundPlayed = false;
   

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartFade());
        
    }

    IEnumerator StartFade()
    {
        black.SetActive(true);
        yield return new WaitForSeconds(3f);
        fadein.SetActive(true);
        black.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        fadein.SetActive(false);
        if (SoundPlayed == false)
        {
            Sound.PlaySound("Lucas_Day3Start");
            SoundPlayed = true;

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
