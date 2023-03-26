using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleanText : MonoBehaviour
{
    public GameObject Black;
    public GameObject fadeout;
    public GameObject fadein;

    public GameObject BloodText;

    bool Cleaned = false;

    public bool GetCleaned()
    {
        return Cleaned;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.E))
        {
            StartCoroutine(Clean());
        }
    }

    IEnumerator Clean()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Black.SetActive(true);
        fadeout.SetActive(false);
        yield return new WaitForSeconds(2f);
        BloodText.SetActive(false);
        fadein.SetActive(true);
        Black.SetActive(false);
        fadein.SetActive(false);
        Cleaned = true;
        //yield return new WaitForSeconds(0.3f);
        

    }
}
