using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public static AudioClip Broom;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {


        Broom = Resources.Load<AudioClip>("Broom");
        


        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {


            case "Broom":
                audioSrc.PlayOneShot(Broom);
                break;

            
        }
    }



}
