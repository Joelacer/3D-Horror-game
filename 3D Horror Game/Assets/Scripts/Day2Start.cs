using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2Start : MonoBehaviour
{
    public GameObject black;
    public GameObject fadein;
    public GameObject fadeout;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
